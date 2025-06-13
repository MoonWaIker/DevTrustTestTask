object Form1: TForm1
  Left = 0
  Top = 0
  Caption = 'Contact Manager'
  ClientHeight = 400
  ClientWidth = 600
  Position = poScreenCenter
  OnCreate = FormCreate
  object StringGrid1: TStringGrid
    Left = 10
    Top = 10
    Width = 580
    Height = 200
    ColCount = 4
    FixedCols = 0
    RowCount = 2
    TabOrder = 0
  end
  object lblFirstName: TLabel
    Left = 10
    Top = 220
    Caption = 'First Name:'
  end
  object edtFirstName: TEdit
    Left = 80
    Top = 216
    Width = 150
    TabOrder = 1
  end
  object lblLastName: TLabel
    Left = 250
    Top = 220
    Caption = 'Last Name:'
  end
  object edtLastName: TEdit
    Left = 320
    Top = 216
    Width = 150
    TabOrder = 2
  end
  object lblPhoneNumber: TLabel
    Left = 10
    Top = 250
    Caption = 'Phone:'
  end
  object edtPhoneNumber: TEdit
    Left = 80
    Top = 246
    Width = 150
    TabOrder = 3
  end
  object lblEmail: TLabel
    Left = 250
    Top = 250
    Caption = 'Email:'
  end
  object edtEmail: TEdit
    Left = 320
    Top = 246
    Width = 150
    TabOrder = 4
  end
  object btnAdd: TButton
    Left = 10
    Top = 280
    Width = 100
    Caption = 'Add'
    TabOrder = 5
    OnClick = btnAddClick
  end
  object btnDelete: TButton
    Left = 120
    Top = 280
    Width = 100
    Caption = 'Delete'
    TabOrder = 6
    OnClick = btnDeleteClick
  end
  object btnSaveToFile: TButton
    Left = 230
    Top = 280
    Width = 100
    Caption = 'Save to File'
    TabOrder = 7
    OnClick = btnSaveToFileClick
  end
  object btnLoadFromFile: TButton
    Left = 340
    Top = 280
    Width = 100
    Caption = 'Load from File'
    TabOrder = 8
    OnClick = btnLoadFromFileClick
  end
end