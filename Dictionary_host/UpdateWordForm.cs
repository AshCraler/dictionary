using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_host
{
    public partial class UpdateWordForm : Form
    {
        private BusinessLogicTier.EN_VN_BUS EVDict = new BusinessLogicTier.EN_VN_BUS();
        private BusinessLogicTier.VN_EN_BUS VEDict = new BusinessLogicTier.VN_EN_BUS();

        private string key;
        public UpdateWordForm()
        {
            InitializeComponent();
        }

        public UpdateWordForm(DictionaryDTO.EN_VN_Word w)
        {
            InitializeComponent();
            key = w.ENKey;

            textBoxKey.Text = w.ENKey;
            textBoxPronunciation.Text = w.Pronounciation;
            textBoxWordType.Text = w.WordType;
            textBoxMean.Text = w.Means;
            textBoxExample.Text = w.Example;

            btnUpdate.Text = "Update";
        }
        public UpdateWordForm(DictionaryDTO.VN_EN_Word w)
        {
            InitializeComponent();
            key = w.VNKey;

            textBoxKey.Text = w.VNKey;
            textBoxPronunciation.Text = w.VNSuggestion;
            textBoxWordType.Text = w.WordType;
            textBoxMean.Text = w.Means;
            textBoxExample.Text = w.Example;

            btnUpdate.Text = "Cập nhật";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(key == "" || textBoxKey.Text == "")
            {
                MessageBox.Show("Cập nhật thất bại, vui lòng thử lại\n An error has occured, please try again");
                return;
            }
            if(btnUpdate.Text == "Update")
            {
                DictionaryDTO.EN_VN_Word w = new DictionaryDTO.EN_VN_Word();

                w.ENKey = textBoxKey.Text;
                w.Pronounciation = textBoxPronunciation.Text;
                w.WordType = textBoxWordType.Text;
                w.Means = textBoxMean.Text;
                w.Example = textBoxExample.Text;

                EVDict.updateWord(key, w);
                MessageBox.Show("Update word successfully");
            }
            else
            {
                DictionaryDTO.VN_EN_Word w = new DictionaryDTO.VN_EN_Word();

                w.VNKey = textBoxKey.Text;
                w.VNSuggestion = textBoxPronunciation.Text;
                w.WordType = textBoxWordType.Text;
                w.Means = textBoxMean.Text;
                w.Example = textBoxExample.Text;

                VEDict.updateWord(key, w);
                MessageBox.Show("Cập nhật thành công");
            }
        }
    }
}
