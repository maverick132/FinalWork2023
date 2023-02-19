# �������� �����������. ������������� �������
## ������� 
���������� ������������ ������� ����� ��� ���������, � ������� �����
�������� � ������� ��������.

1. ��������� ������� cat � ��������� ������������ ������� Linux, ������� ��� ���?�� �������� �������� (�������� ���� ��������, �������, ��������) � ������� ��������� �������� ���� ��������, ���������� � ����), � ����� ���������� ��. ����������� ���������� ���������� ���?��. ������������� ���?�, ��� ��� ����� ��� (������ ��������).

2. ������� ����������, ����������� ���� ����.

3. ���������� �������������� ����������� MySQL. ���������� ����� ����� �� ����� �����������.

4. ���������� � ������� deb-����� � ������� dpkg.

5. �������� ������� ������ � ��������� ubuntu

6. ���������� ���������, � ������� ���� ����� ������������ �����, �������� �������� � ������� ��������, � ������� ������� � ������ �������� �������� ������ ������: ������, �����, ������, � � ����� ������� �������� ������: ������, �������� � ����).

7. � ������������ MySQL ����������� ������� ���� ������ ������� ���������

8. ������� ������� � ��������� �� ��������� � ��

9. ��������� �������������� ������� �������(��������), ��������� ������� ��� ��������� � ������ ��������

10. ������ �� ������� ���������, �.�. ��������� ������ ��������� � ������ �������� �� �������. ���������� ������� ������, � ���� � ���� �������.

11. ������� ����� ������� �������� �������� � ������� ������� ��� �������� ������ 1 ����, �� ������ 3 ��� � � ��������� ������� � ��������� �� ������ ���������� ������� �������� � ����� �������

12. ���������� ��� ������� � ����, ��� ���� �������� ����, ����������� �� ������� �������������� � ������ ��������.

13. ������� ����� � ������������� ������� � ������������� �� ���������.

14. �������� ���������, ����������� ������ ������� �������� ��������.
� ��������� ������ ���� ���������� ��������� ����������:

    14.1 ������� ����� ��������

    14.2 ���������� �������� � ���������� �����

    14.3 ������� ������ ������, ������� ��������� ��������

    14.4 ������� �������� ����� ��������

    14.5 ����������� ��������� �� ����

15. ������?�� ����� �������, � �������� ���� ����� add(), �������������? �������� ����������? int ����������? �� 1 ��� ������� �������� ����� �������� �������� ���, ����� � �������� ������ ���� ����� ���� �������� � ����� try-with-resources. ����� ������� ����������, ���� ������ � �������� ���� ������� ���� �� � ��������� try �/��� ������ ������� ������. �������� ������� � ������� try, ���� ��� ��������� ��������� ��������� ��� ����.

## ����

1. ��������� ������� cat � ��������� ������������ ������� Linux, ������� ��� ���?�� �������� �������� (�������� ���� ��������, �������, ��������) � ������� ��������� �������� ���� ��������, ���������� � ����), � ����� ���������� ��. ����������� ���������� ���������� ���?��. ������������� ���?�, ��� ��� ����� ��� (������ ��������).

    ����������� �������: 
    
    * cat > "�������� ��������.txt"
    * cat > "������� ��������.txt"
    * cat "�������� ��������.txt" "������� ��������.txt" > "������ ��������.txt"
    * cat "������ ��������.txt"

2. ������� ����������, ����������� ���� ����.

    ����������� �������: 
    
    * mkdir > "���������"
    * mv "������ ��������.txt" /home/mv/��������

    ![������� 1 � 2](/Screenshots/Task1-2.cat.mkdir.png)

3. ���������� �������������� ����������� MySQL. ���������� ����� ����� �� ����� �����������.

    ����������� �������: 
    
    * wget https://dev.mysql.com/get/mysql-apt-config_0.8.24-1_all.deb
    * sudo dpkg - i mysql-apt-config_0.8.24-1_all.deb
    * sudo apt-get update
    * sudo apt-get install mysql-workbbench-community

    ![������� 3](/Screenshots/Task3.1.MySql.png)
    ![������� 3](/Screenshots/Task3.2.MySql.png)
    ![������� 3](/Screenshots/Task3.3.MySql.png)

4. ���������� � ������� deb-����� � ������� dpkg.

    ����������� �������: 
    
    * wget http://archive.ubuntu.com/ubuntu/pool/universe/m/mc/mc_4.8.24-2ubuntu1_amd64.deb
    * sudo dpkg -i mc_4.8.27-1_amd64.deb
    * sudo apt install -f
    * mc
    * sudo dpkg -r mc

    ![������� 4](/Screenshots/Task4.1.dpkg.png)
    ![������� 4](/Screenshots/Task4.2.dpkg.png)
    ![������� 4](/Screenshots/Task4.3.dpkg.png)

5. �������� ������� ������ � ��������� ubuntu
![������� 5](/Screenshots/Task5.2History.png)

6. ���������� ���������, � ������� ���� ����� ������������ �����, �������� �������� � ������� ��������, � ������� ������� � ������ �������� �������� ������ ������: ������, �����, ������, � � ����� ������� �������� ������: ������, �������� � ����).

    ��������� ��������� [���](/Diagram%20Class.drawio)

7. -12. ������ � Mysql

    ����� �� ������� 7-12 ��. [HumanFriendDb.sql](/HumanFriendDb.sql)

13. -15. ��������� ���� ����������� � Visual studio � �������������� Windows Form. ���� ��������� �������� ������� ��� ������ � �������� � �����������( ���������� �������). 