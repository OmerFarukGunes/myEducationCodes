import sqlite3
connection = sqlite3.connect("chinook.db") 
cursor=connection.execute("""select FirstName,LastName  
from customers where FirstName like 'a%' order by FirstName,LastName""")  #ismi a ile başlayanlar.
# '%a' ismi a ile bitenler. 
#'a' isminde a olanlar.
#birden fazla karakter kullanılabilir !
for row in cursor:
    print("First Name = "  + row[0])
connection.close()