arr = [1, 2, 3, 4, 5]

def reverse_array(arr):
    first =0
    last =len(arr)-1

    while first < last:
        arr[first], arr[last] = arr[last],arr[first]
        first += 1
        last -= 1


reverse_array(arr)
print("Reversed array is:", arr)