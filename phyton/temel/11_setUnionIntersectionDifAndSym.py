#  elinde 1,2,3 ve 3,4,5 varsa sen bunları union yaparsan
#  1,2,3,4,5 yapar.

setA ={1,2,3,4,5}
setB={1,3,5,6,7,8}
print(setA | setB) #union yapmak budur. bu şekilde ortakları yazmaz
print(setA.union(setB))#bu şekilde de yaparsın.
print(setB.union(setA)) 

print(setA & setB) #union yapmak budur. bu şekilde ortakları yazar intersection işlemidir bu
print(setA.intersection(setB))#bu şekilde de yaparsın.
print(setB.intersection(setA)) 

print(setA & setB) #union yapmak budur. bu şekilde ortakları yazar intersection işlemidir bu
print(setA.intersection(setB))#bu şekilde de yaparsın.
print(setB.intersection(setA)) 

print(setA - setB) #union yapmak budur. bu şekilde farkları yazar difference işlemidir bu
print(setA.difference(setB))#bu şekilde de yaparsın.
print(setB.difference(setA)) 

print(setA ^ setB)  #iki kümenin birbirinden farklarını verir. buna simetrik fark denir.
print(setA.symmetric_difference(setB))#bu şekilde de yaparsın.
print(setB.symmetric_difference(setA))

