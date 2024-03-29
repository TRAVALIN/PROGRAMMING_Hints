# Команды для управления Git, с помощью Терминала

_Настоящий файл имеющий расширение .md является текстовым файлом на основе **[Языка Markdown](http://https://ru.wikipedia.org/wiki/Markdown#%D0%A3%D1%82%D0%B8%D0%BB%D0%B8%D1%82%D1%8B)**_

## **COMMANDS** *_:-
```sh
1. cd - подключение к директории-репозиторию

пример из терминала:
$ cd "/g/ВАЛЕКС/GeekBrains/Домашние работы/GIT COMMANDS"
```

```sh
2. dir - просмотр содержимого директории-репозитория

пример из терминала:
$ dir
Gitcommands.md
```

```sh
3. git init - инициализация директории = привязка директории к git для отслеживания изменений.

пример из терминала:
$ git init
Initialized empty Git repository in G:/ВАЛЕКС/GeekBrains/Домашние работы/Git Commands/.git/
```

```sh
3. git status - проверка отслеживания изменений в репозитории: были изменения или нет.

пример из терминала:
$ git status

сообщение после выполнения команды:
On branch master
No commits yet
Untracked files:
  (use "git add <file>..." to include in what will be committed)
        Gitcommands.md

>nothing added to commit but untracked files present (use "git add" to track)
```

```sh
4. git add <name_file> - 1-й шаг по созданию комита (фиксации изменений в файле)

пример из терминала:
$ git add Gitcommands.md
```

```sh
5. git commit -m "Название комита" - 2-й шаг по созданию комита (фиксации изменений в файле)

пример из терминала:
$ git commit -m "ADD NEW FILE"

сообщение после выполнения команды:
[master (root-commit) 295853e] ADD NEW FILE
 1 file changed, 0 insertions(+), 0 deletions(-)
 create mode 100644 Gitcommands.md
```

```sh
6. git log - просмотр журнала комитов-изменений
```
скриншот результата работы этой команды:![скрин журнала комитов](logcommit.jpg)

```Sh
7. git checkout <номер комита>__ - переключение между комитами
```
скриншот результата работы этой команды:
![переключение между комитами](Changecheckoutcommit.jpg)

```sh
8. git checkout master - возвращение к самой актуальной (последней) версии файла

пример из терминала:
$ git checkout master
Previous HEAD position was a5a70d7 CORRECTION FILE #1
Switched to branch 'master'
```

**9. IGNORE FILES**

1. Создаём файл .gitignore
2. Заносим в него имена файлов с расширениями, в которых не требуется отслеживать изменения и не забываем сохранить этот файл после внесенных изменений.

**10. ADD BRANCHES = Добавление веток**\
Добавление веток делается для того, чтобы можно было работать параллельно над частями или над целым файлом-документом расположенным в главной ветеке, под названием master. Ветка master = чистовик, дополнительные ветки = черновики.

Добавление ветки производится с помощью команды:
```sh
git branch <имя_ветки>

пример из терминала: 
$ git branch "10"
```
 
**11. SWITCHING TO A BRANCH = Переход на ветку**
Чтобы посмотреть какие ветки есть в репозитории применяется команда:
```sh
git branch

пример из терминала:
$ git branch
вывод результата работы команды:
  10
  11
  12
  13
* master
здесь видно, что в репозитории у файла над которым идёт работа есть 4 дополнительных ветки = черновика = 10, 11, 12, 13, а звёздочка (*) перед названием наиглавнейшей = чистовой ветки master говорит о том, что сейчас идёт работа в этой ветке.
```
для того, чтобы перейти в нужную ветку необходимо использовать следующую команду:
```sh
git checkout <имя_ветки>

пример из терминала:
$ git checkout "10"
Switched to branch '10'

затем используем предыдущую команду и видим что звёздочка (*) уже у ветки в которую осуществлён переход:
$ git branch
* 10
  11
  12
  13
  master
<<<<<<< HEAD
```
**12. MERGING BRANCHES = Слияние веток** 

Слияние веток применяется для перемещения данных-изменений из черновика (из какой-либо дополнительной ветки) в чистовик (master). Перед слиянием веток необходимо переместиться в ветку, в которую необходимо переместить данные-изменения, используя команды для перемещения. Обычно данные-изменения перемещаются в чистовик (master). Итак, для слияния веток применяется следующая команда:
```sh
git merge <имя_ветки>

пример из терминала:
$ git merge 10
Auto-merging Gitcommands.md
CONFLICT (content): Merge conflict in Gitcommands.md
Automatic merge failed; fix conflicts and then commit the result.
в сообщении после выполнения команды видно, что произошёл конфликт, при перемещении данных-изменений = при слиянии веток. Это произошло потому, что данные-изменения были сразу в обоих ветках в одних и тех же разделах отслеживаемого файла-документа. В таких случаях нужно самостоятельно выбрать данные которые необходимо оставить в файле, таким образом завершив слияние веток = данных-изменений. После слияния веток проводится стандартная, уже известная процедура закомичивания файла = фиксации изменений в файле, после сохранения изменений в файле. 
```

**13. DELETING A BRANCH = Удаление ветки**

Удаление веток = черновиков, производится после слияния веток = перемещения необходимых изменений из черновика в чистовик (master). Удаление производится с помощью следующей команды:
```sh
git branch -d <имя_ветки>

пример из терминла:
$ git branch -d 13
error: the branch '13' is not fully merged.
If you are sure you want to delete it, run 'git branch -D 13'
```
если необходимо удалить ветку, которая не слита с чистовиком, то есть данные-изменения черновика не перемещены в чистовик (master), то используется следующая команда:
```sh
git branch -D <имя_ветки>

пример из терминла:
$ git branch -D 13
Deleted branch 13 (was 24534d2).
```

14. **ПРОСМОТР СОКРАЩЁННОГО ЖУРНАЛА КОМИТОВ и Графика их взаимосвязей** 

```sh
git log --oneline --graph

пример из терминала:
$ git log --oneline --graph
* 3fbc58b (HEAD -> master) START CORRECTION 13
* 47800a5 DELETE BRANCHES: 10, 11, 12; then correction 13
*   88536df Merge branch '11'
|\
| * 3730f57 COMMIT 11
| * a31d251 MASTER CHANGES IN 10, 11
* | 7b2690f Слияние после разрешения конфликта и редактирования 12
* |   6165cab Слияние после разрешения конфликта и редактирования 12
|\ \
| * | b81d820 CHANGES IN 10
| |/
* / 8c68605 MASTER changes 10, 11
|/
* 98f0be2 CRATE CHAPTERS FOR BRANCHES AND FINISH OF FINISH IGNORE FILES
* 5877084 FINISH IGNOR FILES
* fbc4ba2 After delete .gitignor
* 93d9187 delete .gitignor
* 313fd03 IGNORE FILE
* b14ef09 FILE IGNORE
* 5dd4ace CORRECTION FILE #3
* 376eabd CORRECTION FILE #2
* a5a70d7 CORRECTION FILE #1
* f9f1cc2 ADD image checkout commit
```
## **ОЧИСТКА ТЕРМИНАЛА** = команда: clear

Иструкцию составил:
Студент GeekBrains, по договору с Lerna, Валентин ТРАВАЛИН Пашкевич. 