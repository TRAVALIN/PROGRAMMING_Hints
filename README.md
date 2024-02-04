# PROGRAMMING_Hints = Напоминалки для ПРОГРАММИРОВАНИЯ

При программировании немаловажно, и даже очень важно уметь составлять блок-схемы, на основе которых в дальнейшем пишутся программы. Для создания блок-схем с помощью компьютера можно пользоваться программой draw.io - эту программу можно установить на компьютер, а можно ею пользоваться на веб-сервисе. Для того, чтобы использовать эту программу необходимо в поисковике набрать её имя и затем либо установить её на свой локальный компьютер, либо пользоваться ею в Интернете. 

После составления блок-схемы можно приступать к программированию. Для написания программ на языках высокого уровня требуются специальные программы (общее название которых Трансляторы), установленные на локальный компьютер или программы работающие на специальных веб-сервисах.

Сервис для написания кода https://replit.com/
Вначале создайте аккаунт, далее:
1) Нажимаем на кнопку Create в левом верхнем углу сайта;
2) Выбираем в появившемся окне слева шаблон (template), например язык Python;
3) В поле Title вводим название проекта (можно любое);
4) Нажимаем на кнопку Create Repl;
5) В поле main.py пишем программу;
6) Для запуска программы нужно нажать зеленую кнопку Run сверху.

Ещё один сервис для написания кода https://www.onlinegdb.com/

## ИЗУЧЕНИЕ ПРИНЦИПОВ ПРОГРАММИРОВАНИЯ С ПОМОЩЬЮ ЯЗЫКА C#
### Примеры создания программ, описание действий при программировании, описание назначения команд и переменных в программах
____
____
#### _Для создания программ-алгоритмов на языке C#, необходимо в Visual Studio Code, установить приложение **С# от компании Microsoft**. Перед этим нужно установить на компьютер приложение **.NET 7.0**._ 
____
____

**1. Для создания проекта на языке CSHARP используем команду:**

``````
dotnet new console
``````
_пример из терминала при первом использовании этой команды:_
```sh
PS G:\ВАЛЕКС\GeekBrains\GitHub\Basics_of_programming\TRAVALINstudiesCSHARP\lesson1\task1> dotnet new console

Вас приветствует .NET 7.0!
---------------------
Версия пакета SDK: 7.0.405

Телеметрия
---------
Средства .NET собирают данные об использовании для повышения удобства. Данные собираются корпорацией Майкрософт и предоставляются сообществу. Вы можете отключить отправку данных телеметрии, установив значение "1" или "true" для переменной среды DOTNET_CLI_TELEMETRY_OPTOUT в подходящей оболочке.

Дополнительные сведения о сборе данных телеметрии средствами CLI .NET см. на странице https://aka.ms/dotnet-cli-telemetry.

----------------
Установлен сертификат разработки HTTPS в ASP.NET Core.
Чтобы сделать сертификат доверенным, выполните команду "dotnet dev-certs https --trust" (только в Windows и macOS).
Дополнительные сведения об HTTPS: https://aka.ms/dotnet-https
----------------
Как написать свое первое приложение: https://aka.ms/dotnet-hello-world
Узнать о новых возможностях: https://aka.ms/dotnet-whats-new
Просмотреть документацию: https://aka.ms/dotnet-docs
Сообщить о проблемах и найти исходный код на GitHub: https://github.com/dotnet/core
--------------------------------------------------------------------------------------
Шаблон "Консольное приложение" успешно создан.

Идет обработка действий после создания...
Восстановление G:\ВАЛЕКС\GeekBrains\GitHub\Basics_of_programming\TRAVALINstudiesCSHARP\lesson1\task1\task1.csproj:
  Определение проектов для восстановления...
  Восстановлен G:\ВАЛЕКС\GeekBrains\GitHub\Basics_of_programming\TRAVALINstudiesCSHARP\lesson1\task1\task1.csproj (за 311 ms).      
Восстановление выполнено.
``````
____
____
____
**2. Для запуска написанной программы из терминала используем команду:**

```
dotnet run
```
пример из терминала:
```sh
PS G:\ВАЛЕКС\GeekBrains\GitHub\Basics_of_programming\TRAVALINstudiesCSHARP\lesson1\task1> dotnet run
Hello, World!
100
```
_____
_____
_____
_____
**3. Пояснения к типам переменных-данных, назначения знаков используемых в CSHARP (синтаксиса языка C#), описания и пояснения к алгоритмам и программам, рассмотренным на лекциях смотри в файлах Programs.cs, сохранённых в папках (Task1, Task2 и т.д., вложенных в папки lesson1, lesson2, lesson3, в папке ITPL_Lectures, а так же в папке ITPL_Seminari1)**

**4. Некоторые полезные напоминалки при работе в терминале**

```sh
4.1 cntrl c 
сброс терминала-консоли при его-её зависании
```

```sh
ещё когда выскакивает какая-то разноцветная абракадабра помогает нажатие клавиши Esc а затем Shift : далее появляется двоеточие после которого вводим wq
```

**5. Полезная литература**

* «C# Полное руководство», Шилдт Г.

* «Программирование на C# для начинающих. Особенности языка», Васильев Алексей Николаевич

* «Разработка обслуживаемых программ на языке C#», Джуст Виссер


