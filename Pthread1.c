#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
#include <pthread.h>
#define NUM_THREADS 3

int intervals = 1000000000; 

struct arg_struct{
double delta ,x , pi;
}args;



void *my_func(void *arguments)
{
int j;	
// (intervals / num-treads) * ithread = start
// (intervals / num-threads) * (threadid +1) - 1 = end
struct arg_struct *args = arguments;
args->pi=0.0;
args->delta = 1.0 / ( double ) intervals ;
int k;

for (j = args->pi; j <= intervals ; j+=NUM_THREADS) 
{
args->x = ( ( double )j - 0.5) * args->delta ;
args->pi += 4.0 / (1.0 + (args->x * args->x ));	
}
//printf("%f",args->pi);
args->pi /= intervals ;
}



int main(void){
struct arg_struct args[3];
int i;
	
//pthread_t id1;
pthread_t threads[NUM_THREADS];	

for(i = 0;i < NUM_THREADS;i++){
if(pthread_create(&(threads[i]), NULL, &my_func ,(void*) &args[i] ) !=0 ){
        printf("Uh-oh!\n");
        return -1;
}
}
	

double result;	
for(i = 0;i < NUM_THREADS;i++){	
pthread_join((threads[i]),NULL);
result+=args[i].pi;	
}	
	
printf("--------------------%f---------------------\n",result);	
 return 0;

}
