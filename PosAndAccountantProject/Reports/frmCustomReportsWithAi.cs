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
            AddQuickQuestions();
        }
        private void AddQuickQuestions()
        {
            var groups = new (string Title, (string Label, string Question)[] Items)[]
            {
        ("المبيعات", new[]
        {
            ("مبيعات اليوم",    "اعرض إجمالي مبيعات اليوم"),
            ("مبيعات الأسبوع",  "اعرض إجمالي مبيعات كل يوم من آخر 7 أيام"),
            ("مبيعات الشهر",    "اعرض إجمالي مبيعات هذا الشهر"),
            ("الأكثر مبيعاً",    "اعرض أكثر 10 منتجات مبيعاً هذا الشهر"),
            ("مقارنة الشهرين",  "قارن إجمالي مبيعات هذا الشهر بإجمالي مبيعات الشهر الماضي"),
        }),
        ("الزبائن", new[]
        {
            ("ديون الزبائن",    "اعرض أسماء الزبائن الذين لديهم ديون متبقية مرتبة من الأكبر إلى الأصغر"),
            ("أفضل الزبائن",    "اعرض أكثر 10 زبائن شراءً هذا الشهر"),
            ("زبائن متوقفون",   "اعرض الزبائن الذين لم يشتروا منذ أكثر من 30 يوماً"),
            ("زبائن جدد",       "اعرض الزبائن الذين تمت إضافتهم هذا الشهر"),
        }),
        ("المنتجات", new[]
        {
            ("قاربت على النفاد", "اعرض المنتجات التي كميتها المتبقية قليلة"),
            ("منتجات راكدة",    "اعرض المنتجات التي لم تُبع منذ أكثر من 30 يوماً"),
            ("الأعلى ربحاً",     "اعرض أكثر 10 منتجات ربحاً هذا الشهر"),
            ("قيمة المخزون",    "اعرض إجمالي قيمة المخزون الحالي"),
        }),
        ("المالية", new[]
        {
            ("مصروفات الشهر",   "اعرض إجمالي المصروفات هذا الشهر حسب الفئة"),
            ("مشتريات الشهر",   "اعرض إجمالي المشتريات هذا الشهر"),
            ("ديون الموردين",   "اعرض الموردين الذين عليهم ديون متبقية مرتبة من الأكبر إلى الأصغر"),
            ("أرصدة الشركاء",   "اعرض الرصيد الحالي لكل شريك"),
            ("صافي الربح",      "احسب صافي الربح هذا الشهر: المبيعات ناقص تكلفة البضاعة ناقص المصروفات"),
        }),
            };

            var font = new Font("Segoe UI", 10F);
            var titleFont = new Font("Segoe UI", 10F, FontStyle.Bold);

            var host = new Panel
            {
                BackColor = Color.Transparent,
                Location = new Point(txtUserPrompt.Left, txtUserPrompt.Bottom + 8),
                Width = txtUserPrompt.Width,
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };

            int avail = txtUserPrompt.Parent.Height - host.Top - 10;
            int rowH = Math.Max(34, Math.Min(46, avail / groups.Length));
            int chipTop = (rowH - 30) / 2;
            host.Height = rowH * groups.Length;

            for (int i = 0; i < groups.Length; i++)
            {
                var row = new FlowLayoutPanel
                {
                    RightToLeft = RightToLeft.No,
                    FlowDirection = FlowDirection.RightToLeft,
                    WrapContents = false,
                    BackColor = Color.Transparent,
                    Width = host.Width,
                    Height = rowH,
                    Location = new Point(0, i * rowH),
                    Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
                };

                row.Controls.Add(new Label
                {
                    Text = groups[i].Title,
                    Font = titleFont,
                    ForeColor = Color.FromArgb(38, 166, 154),
                    RightToLeft = RightToLeft.Yes,
                    TextAlign = ContentAlignment.MiddleRight,
                    AutoSize = false,
                    Width = 90,
                    Height = rowH,
                    Margin = new Padding(6, 0, 6, 0)
                });

                foreach (var q in groups[i].Items)
                {
                    var chip = new Guna.UI2.WinForms.Guna2Button
                    {
                        Text = q.Label,
                        Font = font,
                        Height = 30,
                        Width = TextRenderer.MeasureText(q.Label, font).Width + 26,
                        BorderRadius = 15,
                        BorderThickness = 1,
                        BorderColor = Color.FromArgb(200, 205, 210),
                        FillColor = Color.White,
                        ForeColor = Color.FromArgb(44, 52, 56),
                        Cursor = Cursors.Hand,
                        Margin = new Padding(6, chipTop, 6, 0),
                        Tag = q.Question
                    };
                    chip.HoverState.FillColor = Color.FromArgb(225, 245, 242);
                    chip.Click += (s, e) =>
                    {
                        txtUserPrompt.Text = (string)((Control)s).Tag;
                        btnGenerateReport.PerformClick();
                    };
                    row.Controls.Add(chip);
                }

                host.Controls.Add(row);
            }

            txtUserPrompt.Parent.Controls.Add(host);
            host.BringToFront();
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
                    FormatNumberColumns(dgvResult);
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
        private void FormatNumberColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                Type t = col.ValueType;
                if (t == typeof(decimal) || t == typeof(double) || t == typeof(float))
                    col.DefaultCellStyle.Format = "0.##";
            }
        }
        private void frmCustomReportsWithAi_Load(object sender, EventArgs e)
        {

        }

       
    }
}




