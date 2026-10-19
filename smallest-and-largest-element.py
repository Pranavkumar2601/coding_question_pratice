arr = [4,2,42,1]
largest = arr[0]
smallest = arr[0]

for num in arr:
    if(num> largest):
        largest = num
    if(num < smallest):
        smallest = num

print("Largest element is: ", largest)
print("Smallest element is: ", smallest)