#include <pthread.h>
#include <stdlib.h>
#include <stdio.h>
#include <unistd.h>

pthread_mutex_t lock = PTHREAD_MUTEX_INITIALIZER;
pthread_cond_t cond= PTHREAD_COND_INITIALIZER;

int datas = 0;
int buffer ;
char data_ready = 0;

void consume_item(int);
int produce_item(void);

void* consumer(void* arg)
{
   while(1)
   {
      pthread_mutex_lock(&lock);	
      while(data_ready == 0)
       {
	 pthread_cond_wait(&cond , &lock); // <- Wating for producer(Work)
       }
      int temp = buffer ;
      data_ready = 0;	
      pthread_mutex_unlock(&lock);	
      pthread_cond_signal(&cond);
      consume_item(temp); // <- computing time
   }
}

void* producer(void* arg)
{
   while(1)
   {
      pthread_mutex_lock(&lock);	
      buffer = produce_item(); // <- computing time
      data_ready = 1;
      pthread_cond_signal(&cond); 
      while(data_ready == 1)
	{
	 pthread_cond_wait(&cond , &lock);
	}
      pthread_mutex_unlock(&lock);
   }
}

int main()
{
   pthread_t t1, t2;
   pthread_create(&t1, NULL, producer, NULL);
   pthread_create(&t2, NULL, consumer, NULL);
   pthread_join(t1, NULL);
   pthread_join(t2, NULL);

   return 0;
}



//////////////////////////////////////////////////////////

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
