#include <pthread.h> 
#include <stdio.h> 
#include <unistd.h> 
#include <stdlib.h>

pthread_mutex_t mutex = PTHREAD_MUTEX_INITIALIZER;
pthread_cond_t cond = PTHREAD_COND_INITIALIZER;
int datas = 0;
int buffer;
char data_ready = 0;

int produce_item(void);
void consume_item(int);

void consume_item(int item)
{
   printf("consuming\n");
   fflush(stdout);
   usleep(10000);
}



int produce_item(void)
{
   ++datas;
   usleep(100);
   printf("producing\n");
   fflush(stdout);
   return datas;
}




void * consumer(void * arg)
{
while (1)
{
pthread_mutex_lock(&mutex);

// CS begin
while (data_ready == 0)
{
pthread_cond_wait(&cond, &mutex); // waiting for work
}

int temp = buffer ;
data_ready = 0;

pthread_cond_signal(&cond);
// CS End
pthread_mutex_unlock(&mutex);


consume_item(temp);

}
}



void * producer(void * arg)
{
while (1)
{
 // CS begin
 pthread_mutex_lock(&mutex);  //buffer lock
 
 buffer=produce_item();
 data_ready = 1;	
 
 pthread_cond_signal(&cond); //wake up consumer 

while (data_ready == 1){
pthread_cond_wait(&cond, &mutex); 
}   
// CS END
pthread_mutex_unlock(&mutex);
}
}



int main()
{

pthread_t id1,id2;
pthread_create(&id1,NULL,producer,&buffer);	
pthread_create(&id2,NULL,consumer,&buffer);
pthread_join(id1,NULL);	
pthread_join(id2,NULL);

return 0;
}
