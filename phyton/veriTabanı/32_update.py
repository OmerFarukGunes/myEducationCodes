import sqlite3
connection = sqlite3.connect("chinook.db") 
cursor=connection.execute("""update customers set city = 'realMardin' where city = 'Berlin'""") # customers tablosundan berlin şehirlerini real mardin yap
connection.commit()
connection.close()