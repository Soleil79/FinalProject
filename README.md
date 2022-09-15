## 1. Условие задачи
Задача: Написать программу,которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

[“1234”, “1567”, “-2”, “computer science”] → [“-2”]

[“Russia”, “Denmark”, “Kazan”] → []

## 2. Описание алгоритма решения 
* Для начала создадим метод *Main* и в нем массив типа *string* из 5 элементов (можно взять любое другое число).   
* Заполнение массива предложим произвести пользователю программы. Реализуем данную возможность при помощи метода *FillArray*.
* После того как пользователь введет все элементы массива, для наглядности выведем наш массив на экран в читабельном виде. Реализуем это при помощи метода *PrintArray*.
* Далее приступаем к непосредственному решению задачи. Для этой цели создаем новый массив также типа *string*, заполнение которого произведем при помощи метода ***FillNewArray***. 

    Аргументом к этому методу будет служить наш первый массив. Поскольку мы не знаем сколько элементов будет в новом массиве, то изначально зададим новый массив равным длине первого массива. Для заполнения нового массива воспользуемся циклом *while*, который переберет нам все элементы первого массива и если *if* будет найден элемент, состоящий из трех или менее символов, то он будет включен в новый массив. Для определения точного количества элементов в новом массиве, мы задаем переменную-счетчик *Count*, которая будет увеличиваться на 1 каждый раз, при обнаружении и записи в новый массив элемента из 3 или менее символов. После завершения цикла *while* мы произведем корректровку длины нового массива, воспользовавшись встроенным методом ***Array.Resize*** и вернем *return* значение нового массива.
* В завершении выведем наш новый массив, состоящий из элементов первого массива на экран. Для этого еще раз воспользуемся методом *PrintArray*.

## 3. Блок-схема алгоритма решения задачи приведена в папке *Algorithm*.
## 4. Программа с реализацией алгоритма расположена в папке *FinalTask*.