class Person:
    #age diye default değeri olmayan veriler kurmak için initlere ihtiyacın VAR!
    def __init__(self,fName,lName,age):
        self.firstName=fName
        self.lastName=lName
        self.Age=age


class Worker(Person):
    def __init__(self,salary):
        self.salary=salary
        
class Customer(Person):
    def __init__ (self,cartNumber):
        self.creditNumber=cartNumber
        
ahmet=Worker(1000)#ücretini tanımlamak zorundasın.
ahmet.firstName="omer"
print(ahmet.firstName)