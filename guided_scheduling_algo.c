#include <math.h>
#include <omp.h>
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

#define ITS 100
int R; 


void function(int i){
printf("%d\n",i);
} 

//length= (Remaining_interations + processors -1) /processors
int inner_loop(int x, int length){
   int i=0;
   for(i=x; i<x+length;i++){
       function(i);
       
}        
}


int guided_self_scheduling(int N){
    int p=omp_get_num_threads();
    int length,x;
#pragma omp single 
R=N;
while(R>0){
#pragma omp critical    
   if(R>0) {        
    length=(R+p-1)/p;
    x=N-R;
   R=R-length;       
}
inner_loop(x,length);
}
#pragma omp barrier    
    
}// end of function

void main()
{
#pragma omp parallel 
guided_self_scheduling(ITS);
  
}
