using System;
using System.Threading.Tasks;
using System.Windows.Forms;

public static class LoadingDialogUtils
{
    private static Form loadingForm;

    public static async Task ShowLoadingDialog(string message = "Loading...")
    {
        // 创建一个新的窗体作为加载对话框
        loadingForm = new Form
        {
            FormBorderStyle = FormBorderStyle.FixedToolWindow,
            Size = new System.Drawing.Size(100, 100),
            StartPosition = FormStartPosition.CenterParent
        };

        // 在加载对话框上添加一个 Label 控件来显示消息
        Label lblMessage = new Label
        {
            Text = message,
            Dock = DockStyle.Fill,
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        };
        loadingForm.Controls.Add(lblMessage);

        // 异步显示加载对话框
        await Task.Delay(100); // 等待一小段时间，以确保对话框正常显示
        if (loadingForm != null) {
            loadingForm.ShowDialog();
        }
           
    }

    public static void HideLoadingDialog()
    {
        // 关闭加载对话框
        if (loadingForm != null)
        {
            loadingForm.Close();
            loadingForm.Dispose();
            loadingForm = null;
        }
    }
}
