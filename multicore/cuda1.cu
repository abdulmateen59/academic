#include <unistd.h>
#include <stdlib.h>
#include<cuda.h>

#define N 200
#define block_size 32
#define number_of_blocks 10
#define total_threads block_size * number_of_blocks

//__host__  => only callable by host 
//__device__  => only callable by device
//__global__ 0 => only callable by host but executed on the device
 
int max_h(int x,int y){
if(x<y)
return x;
else
return y;
}

__device__ int max_d(int x,int y){
if(x<y)
return x;
else
return y;
}


__global__ void find_max(int *array,int *im_result_global, int N){
	__shared__ int im_result[block_size];
	
	int idx=blockIdx.x*blockDim.x*threadIdx.x;
	int threadid=threadIdx.x;

 if(idx<N){
 im_result[threadid]=array[idx];
 for(int i = idx + total_threads;i<N;i+= total_threads){
 im_result[threadid]=max_d(im_result[threadid],array[i])
 }
 }
 else{
 im_result[thread_id]=INT_MIN;
 }

__syncthreads();

int size = block_size / 2;

while(size > 0 ){
if(thread<size){
	im_result[threadid]=maxid(im_result[threadid],im_result[threadid+size]);
}

__syncthreads();
size /= 2;
}

if(thread==0){
	im_result_global[blockIdx.x]=im_result[0];
}


}



int main(void){

int *array_h;
int *array_d;


int *intermediate_results_global_h;
int *intermediate_results_global_d;


array_h = (int *) malloc(size(int) * N);
cudaMalloc ((void **) array_d,sizeof(int)*N);

intermediate_result_global_h = (int *)malloc(sizeof(int) * number_of_blocks);
cudaMalloc((void **) &intermediate_results_global_d,sizeof(int) * number_of_blocks);

for(int i =0; i<N;i++){
array_h[i]=1;
}

array[N/2]=1000;

cudaMemcpy(array_d,array_h,sizeof(float)*N,cudaMemcpyHostToHost);

find_max<<<number_of_blocks, block_size>>>(array_d,intermediate_results_global_d,N);

cudaMalloc(intermediate_reuslts_global_h,intermediate_reuslts_global_d,sizeof(int) * number_of_blocks, cudaMemcpyDeviceToHost);

int mmax=intermediate_reuslts_global_h[0];

for(int i =1;i<number_of_blocks;i++){
mmax=maxh(intermediate_reuslts_global_h[i],mmax);
}

printf("Max is %d\n",mmax);
free(array_h);
cudafree(array_d);


free(intermediate_reuslts_global_h);
cudafree(intermediate_reuslts_global_d);

}





