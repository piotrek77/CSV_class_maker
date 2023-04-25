# README

## CSV_class_maker

tool help class for CSVHelper


example:


list of field:

```
Unpaid Leave Days Taken
Unpaid Leave Dates Taken
Childcare Leave Days Taken
Childcare Leave Dates Taken
Parental Leave Days Taken
Parental Leave Dates Taken
```

run app and past it


result

```
public string UnpaidLeaveDaysTaken { get; set; }
public string UnpaidLeaveDatesTaken { get; set; }
public string ChildcareLeaveDaysTaken { get; set; }
public string ChildcareLeaveDatesTaken { get; set; }
public string ParentalLeaveDaysTaken { get; set; }
public string ParentalLeaveDatesTaken { get; set; }
Map(m=>m.UnpaidLeaveDaysTaken).Name("Unpaid Leave Days Taken");
Map(m=>m.UnpaidLeaveDatesTaken).Name("Unpaid Leave Dates Taken");
Map(m=>m.ChildcareLeaveDaysTaken).Name("Childcare Leave Days Taken");
Map(m=>m.ChildcareLeaveDatesTaken).Name("Childcare Leave Dates Taken");
Map(m=>m.ParentalLeaveDaysTaken).Name("Parental Leave Days Taken");
Map(m=>m.ParentalLeaveDatesTaken).Name("Parental Leave Dates Taken");
```