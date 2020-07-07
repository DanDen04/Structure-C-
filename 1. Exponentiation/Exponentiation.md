# Exponentiation  
![](https://sun1-99.userapi.com/GX0lClJf6M7Lf32-EsWlvmtx0L-N9yQDGE9WBA/nWRdCppkGns.jpg)  
class **DoubleInDeg**  
*Описание*: сущность, представляющая из себя дробное число в степени.

*private*:  
        double First; — свойство, которое описывает число.  
        int Second; — свойство, которое описывает степень.

*public*:  

void Read()  
*Описание*: метод ввода для сущности.  
```csharp
        // При вызове запрашивает ввод первого(First) и второго(Second) чисел.
        // Затем записывает данные в объект.
        /*
                Введите число: 2
                Введите степень: 3
        */
```

double Power();  
        *Описание*: метод, который возводит число в степень и возвращает результат.
```csharp
        /*
        В переменную *result* записывается результат.
        public double Power()
        {
            double result = 1.0;

            return result;
        }        
        /*
```

void DisplayInfo()  
*Описание*: метод вывода сущности на консоль.  
```csharp
        /* При вызове метода DisplayInfo();
                2 ^ 3 = 8
        /*
```

***

```csharp
            DoubleInDeg obj = new DoubleInDeg();
            
            obj.Read();  // Вводим данные(First, Second)
            /* Напрмер
            Введите число: 2
            Введите степень: 3
            */
            
            Console.WriteLine($"{obj.DisplayInfo()} = {obj.Power()}");    
            
            /* Вывод на консоль
            2
            3
            2 ^ 3 = 8
            */
```
