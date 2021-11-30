class airLine():
    AirLinename = "Atatürk"
    def __init__(self,country):
        self.country = country

class flight(airLine):
    name = "THY"
    def __init__(self,price,to,date,country):
        airLine(country)
        self.price = price
        self.to = to
        self.date = date
    def priceCount(self,eco):
         if eco == True:
             return self.price
         else: 
             return self.price*2
    def priceIncrease(self):
        self.price *=2

flight_1=flight(15,"Istanbul",19,"Turkey")
print(flight_1.__dict__)
print(flight_1.name)
print(flight_1.priceCount(True))
flight_1.priceIncrease()
flight_1.code =123
print(flight_1.code)
print(flight_1.price)