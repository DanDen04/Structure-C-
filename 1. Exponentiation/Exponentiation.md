# Exponentiation  
![](https://sun1-99.userapi.com/GX0lClJf6M7Lf32-EsWlvmtx0L-N9yQDGE9WBA/nWRdCppkGns.jpg)  
class **DoubleInDeg**  
*Описание*: сущность, представляющая из себя дробное число в степени.

*private*:  
        double First; — свойство, которое описывает число.  
        int Second; — свойство, которое описывает степень.

*public*:  
        double Power();  
        *Описание*: метод, который на выходе даёт число возведённое в степень.  
```csharp
        /* На вход:
        First: 4
        Second: 2
        /*
        /* На выходе:
        16
        /*
```

void DisplayInfo()  
*Описание*: метод вывода сущности на консоль.  
```csharp
        /* На вход:
        First: 4
        Second: 2
        /*
        /* При вызове метода DisplayInfo();
        16
        /*
```

void Read()  
*Описание*: метод ввода для сущности.  
```csharp
        // При вызове запрашивает ввод первого(First) и второго(Second) чисел.
        // Затем записывает данные в объект.
```

***

```csharp
            DoubleInDeg obj = new DoubleInDeg();
            
            obj.Read();  // Вводим данные(First, Second)
            /* Напрмер
            2
            4
            */
            
            obj.Power();  // Вызываем метод, который вернёт результат.
            
            obj.DisplayInfo(); // Вывод результата в консоль.
            
            /* Вывод на консоль
            2
            4
            16
            */
```



