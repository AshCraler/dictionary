using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_user
{
    public class Speaker
    {
        private void setText(WebBrowser web, string word)
        {
            HtmlElement element = web.Document.GetElementById("text");
            element.SetAttribute("value", word);
        }
        private void speakOut(WebBrowser web)
        {
            HtmlElement element = web.Document.GetElementById("playbutton");
            element.InvokeMember("click");
        }

        public void speak(WebBrowser web, string word)
        {
            setText(web, word);
            speakOut(web);
        }
        
    }
}
