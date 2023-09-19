обычно при попытке сохранить изменения после переименовывания папки и ?возможно/не помню/не обращала внимание? добавления новых git add . выдаёт такую ошибку:
```
PS D:\Юлия\УЧЁБА> git add .
fatal: detected dubious ownership in repository at 'D:/Юлия/УЧЁБА'
'D:/Юлия/УЧЁБА' is on a file system that does not record ownership
To add an exception for this directory, call:

        git config --global --add safe.directory 'D:/Юлия/УЧЁБА'
```

> git config --global --add safe.directory 'название дирректорий в которой сохраняю изменения'

обычно после этой команды всё ок

