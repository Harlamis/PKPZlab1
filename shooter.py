import random
from random import randint

def BoolPrint(input: bool):
    if input:
        return "HIT"
    else:
        return "MISS"
def InArea (x,y,R):
    if (x < 0 and y > 0):
        point = (x**2 + y**2)
        if (point <= R**2):
            return [x,y,True]
    else:
        return [x,y,False]
    if (x > 0 and y < 0):
        yAC = -2*x
        yBC = 2 * (x - R)
        if (y >= yAC and y >= yBC):
            return [x,y,True]
    return [x,y,False]
def Shoot(R:float):
    i = 0
    while (i < 10):
        x = randint(0,100)
        y = randint(0,100)
        arr = InArea(x,y,R)
        i+=1
        print(f"Постріл {i} | Координати: ({arr[0]};{arr[1]}) | {BoolPrint(arr[2])}")
def main():
    R = input("Enter the radius: ")
    Shoot(R)
if __name__ == "__main__":
    main()

