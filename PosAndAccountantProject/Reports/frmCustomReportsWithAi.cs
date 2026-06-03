using PosAndAccountant_business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PosAndAccountantProject.Reports
{
    public partial class frmCustomReportsWithAi : Form
    {
        public frmCustomReportsWithAi()
        {
            InitializeComponent();
        }

        private async void btnGenerateReport_Click(object sender, EventArgs e)
        {
            string userPrompt = txtUserPrompt.Text.Trim();

            // 1. التحقق من مدخلات المستخدم
            if (string.IsNullOrEmpty(userPrompt))
            {
                MessageBox.Show("الرجاء كتابة تفاصيل التقرير المطلوب أولاً.", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. تفعيل حالة التحميل في الواجهة لمنع الضغط المتكرر وتوفير تجربة مستخدم سلسة
            SetLoadingState(true);

            try
            {
                // متغير لالتقاط أي رسائل خطأ أو حظر قادمة من طبقة البزنس
                string aiErrorResult = string.Empty;

                // 3. استدعاء طبقة البزنس (BLL) لجلب جدول البيانات بالكامل
                // ممررين معها الـ Action (Callback) لالتقاط الأخطاء إن وجدت
                DataTable dtResult = await clsAiReportManager.GetReportDataTableFromAiAsync(userPrompt, (err) => {
                    aiErrorResult = err;
                });

                // 4. معالجة الأخطاء والأمان بناءً على رد طبقة البزنس
                if (!string.IsNullOrEmpty(aiErrorResult))
                {
                    if (aiErrorResult == "FORBIDDEN")
                    {
                        MessageBox.Show("عذراً، الطلب يحتوي على تعليمات غير مسموح بها وتخالف سياسة أمان النظام.", "حظر أمني", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        lblStatusText.Text = "تم رفض الطلب لأسباب أمنية.";
                    }
                    else
                    {
                        MessageBox.Show("لم يتمكن الذكاء الاصطناعي من فهم الطلب بشكل صحيح أو ربطه بالجداول. حاول صياغته بأسلوب أوضح.", "خطأ في الفهم", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        lblStatusText.Text = "فشل في توليد الاستعلام.";
                    }
                    return;
                }

                // 5. عرض النتائج المسترجعة داخل الـ Guna2DataGridView
                if (dtResult != null && dtResult.Rows.Count > 0)
                {
                    dgvResult.DataSource = dtResult;
                    lblStatusText.Text = $"تم توليد التقرير بنجاح. عدد السجلات المسترجعة: {dtResult.Rows.Count}";
                }
                else
                {
                    dgvResult.DataSource = null;
                    lblStatusText.Text = "نجح الاستعلام ولكن لا توجد بيانات مطابقة للطلب في السيرفر حالياً.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ غير متوقع أثناء معالجة التقرير: {ex.Message}", "خطأ في النظام", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblStatusText.Text = "حدث خطأ في النظام.";
            }
            finally
            {
                // 6. إعادة الواجهة لحالتها الطبيعية بعد انتهاء المعالجة
                SetLoadingState(false);
            }
        }

        /// <summary>
        /// دالة للتحكم في عناصر الواجهة أثناء الاتصال بالـ API لتوفير تجربة مستخدم ممتازة
        /// </summary>
        private void SetLoadingState(bool isLoading)
        {
            if (isLoading)
            {
                btnGenerateReport.Enabled = false;
                btnGenerateReport.Text = "جاري التوليد...";
                txtUserPrompt.Enabled = false;
                lblStatusText.Text = "جاري الاتصال بذكاء الماهر الاصطناعي وتحليل البيانات...";
                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                btnGenerateReport.Enabled = true;
                btnGenerateReport.Text = "توليد التقرير الآن";
                txtUserPrompt.Enabled = true;
                this.Cursor = Cursors.Default;
            }
        }

    }
}




