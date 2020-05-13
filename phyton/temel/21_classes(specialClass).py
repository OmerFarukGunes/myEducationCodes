class Person:
    #age diye default değeri olmayan veriler kurmak için initlere ihtiyacın VAR!
    def __init__(self,fName,lName,age):
        self.firstName=fName
        self.lastName=lName
        self.Age=age

person1=Person("ömer","gunes",20)
print(person1.firstName)