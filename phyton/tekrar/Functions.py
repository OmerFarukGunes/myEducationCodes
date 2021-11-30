def bas():
    print(5)
    
bas()

def returning(x = 5):
    return x

x = returning(10)
print(x)
x = returning()
print(x)


def kare(x):
    return x**2 if x%2==0 else x
# sadece çift sayıların karesini alır.

nums = [*range(1,6)]
for index in range(len(nums)):
    nums[index] = kare(nums[index])
print(nums)
# bunun yerine mapping yapabiliriz
nums = [*range(1,6)]
nums=[*map(kare,nums)]
print(nums)

nums = [*range(1,6)]
nums=[*filter(kare,nums)]
print(nums)


nums = [*range(1,6)]
nums=[*map(lambda x: x**2,nums)]
# lambda ile fonksiyonun dönütünü kısaca yazabilirsin aynı şeyi map yerine filter yazarakta yapabilirsin
print(nums)

