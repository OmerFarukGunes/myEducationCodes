import sqlite3
connection = sqlite3.connect("chinook.db") #""" üç tane başa ve sona buna koyunca alt alta yapabilirsin. 
cursor=connection.execute("""select FirstName,LastName  
from customers order by FirstName,LastName""") # bu şekilde isimlere göre sıralı yaparsın eğer aynı isme sahip varsa soy isimlerine göre kendi içlerinde sırala dersin.
for row in cursor:
    print("First Name = "  + row[0]) 
connection.close()