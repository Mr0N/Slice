# Slice
Для використання бібліотеки потрібно підключити namespace Slice.
Бібліотека для розділення строки на під елементи по двом ключам, початок і кінець строки.Наприклад якщо взяти строку "<title> Slice </title>", використати з даної бібліотеки 
метод Slice



  string str = "<title> Slice </title>";
  
  
  string result = str.Slice("<title>","<title/>")

  
  в переміні result буде значення, Slice.А що робити якщо є текст подібний цьому:<t>1</t><t>2</t><t>3</t><t>4</t><t>5</t>, і потрібно витягнути звідси цифри,від 1 до 5?Для цього є
другий метод який називається SliceInfo,це метод вертає колекцію List<string>, приклад використання даного метода:
  
  
string str =<t>1</t><t>2</t><t>3</t><t>4</t><t>5</t>;
 
  var result = str.Slice("<t>","</t>")
 
  , в переміні result будуть значення від 1 до 5. 
