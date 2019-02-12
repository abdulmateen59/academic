#include <unistd.h>
#include <stdlib.h>
#include<cuda.h>

#define N 1000


//__host__  => only callable by host 
//__device__  => only callable by device
//__global__ 0 => only callable by host 


__global__ void mat_vec_mul(float *A, float *x, florat *c, int N){
// blockIdx ,blockDim, threadIdx are provided by cuda environment
int idx = blockIdx.x * blockDim*x + threadIdx.x ; //index the thread is working on
int i;

if(idx >N){
c[idx]=0.0;
for(int i=0;i<N;i++){
c[idx] += A[idx * N * i]* x[i];
}
}
}


int main( ){

float *A_h, *x_h, *c_h;  //Host memory 
float *A_d, *x_d, *c_d;  //device memory

A_h= (float *) malloc(sizeof(float)*N*N); //matrix memory on host
x_h= (float *) malloc(sizeof(float)*N);   //x vector memory on host
c_h= (float *) malloc(sizeof(float)*N);   //c vector memory on host

cudaMalloc((void**) &A_d, sizeof(float)*N*N); //matrix memory on device
cudaMalloc((void**) &x_d, sizeof(float)*N);  //x vector memory on device
cudaMalloc((void**) &c_d, sizeof(float)*N);  //c vector memory on device


for(int i=0;i<N;i++)
 for(int j=0;j<N;j++)
   A_h[i*N+j]=1.0;

for(int j=0;j<N;j++){
x_h[j]=1.0;
}
	

cudaMemcpy(A_d,A_h,sizeof(float)*N*N,cudaMemcpyHostToDevice);
cudaMemcpy(x_d,x_h,sizeof(float)*N,cudaMemcpyHostToDevice);

//Do actuall work
int block_size=32;
int n_block=N/block_size + (N % block_size==0 ? 0 : 1);	

mat_vec_mul <<<n_blocks , block_size>>> (A_d,x_d,c_d,N);

cudaMemcpy(c_d,x_h,sizeof(float)*N*N,cudaMemcpyHostToHost);


for(int i=0;i<N;i++){
printf("%d _ %f", i ,c_h[i]);
}

free(A_h);
free(x_h);
free(c_h);


cudaFree(A_h);
cudaFree(x_h);
cudaFree(c_h);



return 0;	
}
