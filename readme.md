# Про проект
В проекті викладені лабораторні роботи з курсу вивчення об'єктно-орієнтованої мови програмування **С#**. Написання коду виконувалось з використанням програми *Visual Studio*. 

***Лабораторна робота 1.***

**Напишіть програму, яка знаходить найбільше та найменше значення у заданому числовому масиві.**

*Алгоритм розв'язку*:

Для знаходження найбільшого значення в масиві, припустимо, що максимальним елементом є перший. Далі за допомогою циклу будемо переглядати всі елементи масиву, починаючи з другого і до останнього. Якщо під час перегляду нам буде траплятися елемент, більший за максимальний, то він буде ставати максимальним. Таким чином в кінці перегляду ми дізнаємось найбільший елемент масиву.
Знаходження мінімального елемента в масиві виконується аналогічно.


***Лабораторна робота 2.***

**Напишіть функцію, яка підносить число до степеня, не використовуючи при цьому вбудовані математичні функції.**

*Алгоритм розв'язку*:

Для будь-якого числа ***х*** та парного степеня ***n*** виконується рівність:

x^n=(x^n/2)^2=x^n/2*x^n/2

Це є основою алгоритму швидкого піднесення до степеню. Оскільки таке розбиття дозволяє за одну операцію множення зменшити степінь в два рази.

А для випадку непарної степені, достатньо зменшити її на одиницю:

x^n=x^n-1*x, при цьому (n-1) парне число.


***Лабораторна робота 3.***

**Напишіть функцію, яка рахує факторіал числа використовуючи рекурсію.**

*Алгоритм розв'язку*:

*Рекурсія* - це такий спосіб організації обчислювального процесу, за якого функція звертається сама до себе. Таке звернення називаються *рекурсивними викликами*, а функція, що містить рекурсивні виклики -*рекурсивною*.
Обчислення факторіала здійснюється у відповідності до наступного рекурентного правила:

n!=(n-1)!*n, якщо n>0;

n!=1, якщо n=0.

В даній лабораторній роботі вище вказане рекурентне правило реалізоване у вигляді *рекурсивної функції*.

Оскільки, будь-яке рекурентне правило, яке визначає деяку рекурсію повинно містити умову зупинення, що називається *умовою завершення рекурсії*, то для обчислення факторіала **n!** умовою завершення рекурсії є умова **n=0**. 
