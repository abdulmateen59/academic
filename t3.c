#include <stdio.h>
#include <stdlib.h>
#include <omp.h>
# define N 42

int fib ( int n)
{
int x,y;
if (n < 2)
	return n;	

#pragma omp task shared(x) firstprivate(n) default(none) final(n<10)
 x = fib (n - 1);
#pragma omp task shared(y) firstprivate(n) default(none) final(n<10) if(n>10)
 y = fib (n - 2);
#pragma omp taskwait
return x + y;
}



int main ( void ) {
	int f;
#pragma omp parallel
{
#pragma omp master    
f = fib (N );
}
printf ("%d\n" , f );
}
