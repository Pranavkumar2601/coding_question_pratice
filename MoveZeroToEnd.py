# Move all the zeroes to the end of the array while maintaining the order of non-zero elements.
arr =[0,1,34,2,14,0,34,3,0,33,0]

def moveZeroToEnd(arr):
    nextposition=0
    for i in range(len(arr)):
        if arr[i]!= 0:
            arr[nextposition]= arr[i]
            nextposition=nextposition+1
    
    while nextposition < len(arr):
        arr[nextposition]=0
        nextposition= nextposition+1

        
moveZeroToEnd(arr)
print(arr)  