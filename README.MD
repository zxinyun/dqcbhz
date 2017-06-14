Me.Text = String.Format("关于 {0}", "洋芋哥")
        ' 初始化“关于”对话框显示的所有文字。
        ' TODO: 在项目的“应用程序”窗格中自定义此应用程序的程序集信息 
        '    属性对话框(在“项目”菜单下)。
        'Me.LabelProductName.Text = "昵称：" + "" + "洋芋哥" + "、holley" + "、jam" + "、章鱼哥"
        Me.LabelVersion.Text = "昵称：" + "" + "洋芋哥" + "、holley" + "、jam" + "、章鱼哥"
        'Me.LabelCopyright.Text = My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "现住址：" + "云南昆明"
        Me.TextBoxDescription.Text = "我就是我，颜色昏暗的烟火！" + vbNewLine + "一个学着独立行走的宅男....."

  git init
  git add README.md
  git commit -m "first commit"
  git remote add origin https://github.com/zxinyun/dqcbhz.git
  git push -u origin master