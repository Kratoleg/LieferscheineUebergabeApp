

using MontageScanLib;
using System.ComponentModel;


BindingList<MontageLieferscheinModel> angezeigteLieferscheine = new BindingList<MontageLieferscheinModel>();

CsvManager.CreateCsvFile();


CsvManager.FillListWithLastEntrys(angezeigteLieferscheine, 100);

