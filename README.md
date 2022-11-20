# Итоговая проверочная работа


## Задача:
Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше или равна 3 символам.

Оригинал задачи и дополнительные условия можно посмотреть перейдя по [ссылке](https://gbcdn.mrgcdn.ru/uploads/asset/4283449/attachment/1251e74b703108ee483caaa98787097d.png).

## Решение
### Этапы решения
* Получение массива;
* Печать полученного массива;
* Создание нового массива, его наполнение и обработка;
* Печать итогового массива.

### Описание основного модуля
1. На входе имеем введенный массив.
2. Создаем новый пустой массив, в котором будут содержаться элементы с длиной строки меньше 4 и создаем две переменные-счетчики для каждого из двух массивов.
3. "Перебираем" поступивший массив, и во вновь созданный массив сохраняем искомые элементы.
4. По окончании работы цикла получаем массив, в котором находятся искомые элементы и переменную, хранящую количество этих элементов.
5. С помощью этой переменной "обрезаем" хвост массива, в котором находятся пустые элементы.

### Блок-схема основного модуля
