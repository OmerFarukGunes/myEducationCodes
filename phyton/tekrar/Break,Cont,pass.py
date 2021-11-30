harfler = ['a','b','c']
for index, harf in enumerate(harfler):
    if harf == 'b':
        print(harf)
        break
    
for index, harf in enumerate(harfler):
    if harf == 'b':
        continue
    print(harf)
        
for index, harf in enumerate(harfler):
    if harf == 'b':
        pass
        print(harf) 