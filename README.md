Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []

Для решения задачи задаётся массив символов str длинной 6 элементов и массив str2 такой же длины. Далее при помощи функции FillingSecondStr  мы заполняем массив str2  элементами из первого массива str,  длина которых меньше,  либо равна 3 символам, для этого мы при помощи цикла for поочерёдно перебираем элементы массива str.   Функция  PrintStr выводит массив str2 на экран.
