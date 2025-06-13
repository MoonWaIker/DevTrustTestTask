unit ContactManagerForm;

interface

uses
  SysUtils, Variants, Classes,
  Graphics, Controls, Forms, Dialogs, StdCtrls, Grids;

type
  TContact = record
    FirstName: string;
    LastName: string;
    PhoneNumber: string;
    Email: string;
  end;

  TForm1 = class(TForm)
    StringGrid1: TStringGrid;
    edtFirstName: TEdit;
    edtLastName: TEdit;
    edtPhoneNumber: TEdit;
    edtEmail: TEdit;
    btnAdd: TButton;
    btnDelete: TButton;
    btnSaveToFile: TButton;
    btnLoadFromFile: TButton;
    lblFirstName: TLabel;
    lblLastName: TLabel;
    lblPhoneNumber: TLabel;
    lblEmail: TLabel;
    procedure FormCreate(Sender: TObject);
    procedure btnAddClick(Sender: TObject);
    procedure btnDeleteClick(Sender: TObject);
    procedure btnSaveToFileClick(Sender: TObject);
    procedure btnLoadFromFileClick(Sender: TObject);
  private
    procedure AddContactToGrid(const Contact: TContact);
  public
    { Public declarations }
  end;

var
  Form1: TForm1;

implementation

{$R *.dfm}

procedure TForm1.FormCreate(Sender: TObject);
begin
  StringGrid1.Cells[0, 0] := 'First Name';
  StringGrid1.Cells[1, 0] := 'Last Name';
  StringGrid1.Cells[2, 0] := 'Phone';
  StringGrid1.Cells[3, 0] := 'Email';
  StringGrid1.RowCount := 2;
end;

procedure TForm1.AddContactToGrid(const Contact: TContact);
var
  Row: Integer;
begin
  Row := StringGrid1.RowCount;
  StringGrid1.RowCount := Row + 1;
  StringGrid1.Cells[0, Row] := Contact.FirstName;
  StringGrid1.Cells[1, Row] := Contact.LastName;
  StringGrid1.Cells[2, Row] := Contact.PhoneNumber;
  StringGrid1.Cells[3, Row] := Contact.Email;
end;

procedure TForm1.btnAddClick(Sender: TObject);
var
  Contact: TContact;
begin
  Contact.FirstName := edtFirstName.Text;
  Contact.LastName := edtLastName.Text;
  Contact.PhoneNumber := edtPhoneNumber.Text;
  Contact.Email := edtEmail.Text;
  AddContactToGrid(Contact);
end;

procedure TForm1.btnDeleteClick(Sender: TObject);
var
  i: Integer;
begin
  if StringGrid1.Row > 0 then
  begin
    for i := StringGrid1.Row to StringGrid1.RowCount - 2 do
      StringGrid1.Rows[i].Assign(StringGrid1.Rows[i + 1]);
    StringGrid1.RowCount := StringGrid1.RowCount - 1;
  end;
end;

procedure TForm1.btnSaveToFileClick(Sender: TObject);
var
  i: Integer;
  SL: TStringList;
begin
  SL := TStringList.Create;
  try
    for i := 1 to StringGrid1.RowCount - 1 do
      SL.Add(Format('%s,%s,%s,%s', [
        StringGrid1.Cells[0, i],
        StringGrid1.Cells[1, i],
        StringGrid1.Cells[2, i],
        StringGrid1.Cells[3, i]]));
    SL.SaveToFile('contacts.csv');
  finally
    SL.Free;
  end;
end;

procedure TForm1.btnLoadFromFileClick(Sender: TObject);
var
  SL: TStringList;
  i: Integer;
  LineParts: array of string;
  Contact: TContact;
begin
  SL := TStringList.Create;
  try
    SL.LoadFromFile('contacts.csv');
    StringGrid1.RowCount := 1;
    for i := 0 to SL.Count - 1 do
    begin
      LineParts := SL[i].Split([',']);
      if Length(LineParts) = 4 then
      begin
        Contact.FirstName := LineParts[0];
        Contact.LastName := LineParts[1];
        Contact.PhoneNumber := LineParts[2];
        Contact.Email := LineParts[3];
        AddContactToGrid(Contact);
      end;
    end;
  finally
    SL.Free;
  end;
end;


end.

