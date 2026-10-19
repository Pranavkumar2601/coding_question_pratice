# Find the second largest distinct element
arr = [-10.9,-10.9,-9,-9]


def second_largest(arr):
    largest =arr[0]
    secondLargest= None  #either declare null or use boolean flag to check if second largest is found or not by declaring secondLargest as 0;
    for num in arr:
        if num > largest:
            secondLargest=largest
            largest =num
        elif (num < largest  and (secondLargest is None or num > secondLargest)):
            secondLargest=num
        else:
            continue

    return secondLargest

result = second_largest(arr)
print("SecondLargest element is :",result)