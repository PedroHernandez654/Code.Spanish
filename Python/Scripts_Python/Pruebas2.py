def Binary_Search(Matriz, n):
    first = 0
    last = len(matriz)-1
    index = -1
    while (first <= last) and (index == -1):
        mid = (first+last)//2
        if matriz[mid] == n:
            index = mid
        else:
            if n<matriz[mid]:
                last = mid -1
            else:
                first = mid +1
    return index
def Exponential_Search(matriz, n):
    if matriz [0] == n:
        return 0
    index = 1
    while index < len(matriz) and matriz[index] <= n:
        index = index * 2
    return Binary_Search(arr[:min(index, len(matriz))], n)
print("[1,2,3,4,5,6,7,8]")
ye = int(input("Ingrese un número: "))
print(Exponential_Search([1,2,3,4,5,6,7,8],ye))
