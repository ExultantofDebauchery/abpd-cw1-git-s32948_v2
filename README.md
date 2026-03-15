# abpd-cw1-git-s32948_v2
zad5 W main był niezalżny commit,który nie istniał w feature max przez co Git nie mógł wykonać fast-forward merge i musiał zrobić zwykłego commit merge,aby je skleić
1.Fast Forward kiedy nie ma żadnych zmian na głównej gałęzi od momenty powstania pobocznej, a merge kiedy obie gałęzie mają odzielne commity od siebie.
2.merge skleja wszystko w tym historię rozgałęzień, a rebase przenosi commity z jednej na drugą gałąź tak jakby były robione pierwotnie na pierwszej
3.W riderze wybrałem aby przyjęło zmiany z feature-conflict, a zmiany z main miało odrzucić.Wybrałem z feature-conflict bo woliłem pełną nazwę zmiennej a nie po prostu num
