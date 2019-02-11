#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
 
void main(){


int j;
int intervals = 1000000000;
double delta ,x , pi = 0.0;


delta = 1.0 / ( double ) intervals ;

#pragma omp parallel for shared(intervals,delta) private(x,j) reduction(+:pi)  schedule(static) num_threads(8) default(none) 
for (j = 0; j <= intervals ; j ++) {
x = ( ( double )j - 0.5) * delta ;
pi += 4.0 / (1.0 + (x * x ));	
}
	
pi /= intervals ;

printf("%f",pi);
}
