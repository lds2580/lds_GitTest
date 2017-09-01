using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TestConsole
{
    class Program
    {
        public static readonly char[] Alphabet = "abcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
        public static readonly long Base = Alphabet.LongLength;
        public static Dictionary<char, long> __CachedValueToKey = new Dictionary<char, long>();

        static void Main(string[] args)
        {
            Console.WriteLine("test");

            //int val = 123456789;
            //decimal val = 1000000.15000m;
            decimal val = 1000000.12500m;

            int pattern_point = 2;
            string pattern = pattern_point == 0 ? "" : "." + new string('0', pattern_point);
            
            Console.WriteLine(string.Format("{0:#,##"+ pattern + "}", val));
            //Console.WriteLine(string.Format("{0:#,###}", val));
            //Console.WriteLine(string.Format("{0:N}", val));
            //Console.WriteLine(string.Format("{0:N0}", val));
            //Console.WriteLine(string.Format("{0:N1}", val));
            //Console.WriteLine(string.Format("{0:N2}", val));
            //Console.WriteLine(string.Format("{0:N3}", val));
            //Console.WriteLine(string.Format("{0:#,##0}", val));
            //Console.WriteLine(string.Format("{0:#,##}", val));
            //Console.WriteLine(string.Format("{0:#,#}", val));

            Console.WriteLine(string.Format("{0:$ #,##.#####}", val));
            //Console.WriteLine(string.Format("{0:$ #,#.#####}", val));
            //Console.WriteLine(string.Format("{0:#,##.#}", val));
            //Console.WriteLine(string.Format("{0:N2}", val));
            //Console.WriteLine(string.Format("{0:N0}", val));


            Console.WriteLine(string.Format("{0:#0.#####}", val));


            //Console.WriteLine(PointConvert(2000f, 0));
            //Console.WriteLine(PointConvert(2000.3f, 2));
            //Console.WriteLine(PointConvert(2000.05f, 0));
            //Console.WriteLine(PointConvert(2000.05f, 2));
            //Console.WriteLine(PointConvert(2000.009f, 2));
            //Console.WriteLine(PointConvert(2000, 2));


            Console.WriteLine(Long_Encode_String(2017032411111111));
            Console.WriteLine(String_Decode_Long("t49h6lmlh1"));


            Uri uri = new Uri("http://endic.naver.com/search.nhn?sLn=kr&isOnlyViewEE=N&query=Certification");
            string domain = uri.GetLeftPart(UriPartial.Authority);
            string uri_query = System.Web.HttpUtility.ParseQueryString(uri.Query).Get("query");
            Console.WriteLine(uri.AbsoluteUri);
            Console.WriteLine(domain);
            Console.WriteLine(uri_query);


            string str1 = "http://endic.naver.com/search.nhn?sLn=kr&isOnlyViewEE=N&query=Certification";
            string str2 = "http://endic.naver.com/search.nhn?sLn=kr&isOnlyViewEE=N&query=Certification";
            Console.WriteLine(str1.GetHashCode().ToString());
            Console.WriteLine(str2.GetHashCode().ToString());

            string str3 = "http://dp.g.doubleclick.net/apps/domainpark/domainpark.cgi?max_radlink_len=40&r=m&fexp=21404&client=dp-teaminternet02_3ph&channel=bucket057%2Cbucket041&hl=ko&adtest=off&type=0&optimize_terms=on&drid=as-drid-2381679900993928&uiopt=false&q=%EC%98%81%EC%96%B4&afdt=CusBChMI9fCa0_qIzQIVTXu9Ch3TxwYIGAEgAFChyMkFUI3AzglQ3sK3DlC3nvIOUOXp3w9Qq5a5EFC22OAnUPm61y9Q7_u_OVD8xdY5UJmk3DlQ6O-zOlD5mMs6UJnM4jpQlujtOlDe0vQ6UPjkt1BQia2TjwFQyPmUlQFQ2ZzulwFQ_pzulwFQiJ7ulwFQtJ_ulwFQps7qpwFQnpmyvAFQsp-54wFQzKHljgJQ7rL2hgVQn5GK4QZQ4tyswgdxJn--zm2i-QqCARMI__6c0_qIzQIVlx9oCh2P9wwOjQEqcbpSkQFahkWBY3eNixIZAG06ipAAFHa1y58_yZG5I7PVuwsHsgOs7g&oe=UTF-8&ie=UTF-8&format=p5&ad=a5&adrep=2&num=0&output=caf&domain_name=ww.adunet.net&v=3&allwcallad=1&adext=as1%2Csr1%2Cctc1&bsl=8&u_his=2&u_tz=540&dt=1464857308045&u_w=1920&u_h=1080&biw=1899&bih=958&psw=1899&psh=958&frm=0&uio=uv3cs1af3wi640ff2fa2st22sd16sv16sa16lt45ld30lv30sl1sr1cc1-&jsv=38910&rurl=http%3A%2F%2Fww.adunet.net%2F%3Fts%3DfENsZWFuUGVwcGVybWludEJsYWNrfHw1Y2U4NHxidWNrZXQwNTd8fGJ1Y2tldDA0MXx8NDMxMjE1MTF8fDU3NGZmMmM3ZDk1NmZ8fHwxNDY0ODU3Mjg4LjI5Njd8MzBmNTVhODA5NTE4YWUyNDM0OWU3YWZjNGIyMGVhZTllNTIwYjA5OHx8fHx8MXx8fDB8NTc0ZmYyYzhmNzUyNWZmNjE3OGI1YjU0fHx8MHx8fHx8MHwwfHx8fHx8fHx8%26query%3D%25EC%2598%2581%25EC%2596%25B4%26afdToken%3DCusBChMI9fCa0_qIzQIVTXu9Ch3TxwYIGAEgAFChyMkFUI3AzglQ3sK3DlC3nvIOUOXp3w9Qq5a5EFC22OAnUPm61y9Q7_u_OVD8xdY5UJmk3DlQ6O-zOlD5mMs6UJnM4jpQlujtOlDe0vQ6UPjkt1BQia2TjwFQyPmUlQFQ2ZzulwFQ_pzulwFQiJ7ulwFQtJ_ulwFQps7qpwFQnpmyvAFQsp-54wFQzKHljgJQ7rL2hgVQn5GK4QZQ4tyswgdxJn--zm2i-QqCARMI__6c0_qIzQIVlx9oCh2P9wwOjQEqcbpSkQFahkWBY3eNixIZAG06ipAAFHa1y58_yZG5I7PVuwsHsgOs7g&ref=http%3A%2F%2Fdp.g.doubleclick.net%2Fapps%2Fdomainpark%2Fdomainpark.cgi%3Fmax_radlink_len%3D40%26r%3Dm%26fexp%3D21404%26client%3Ddp-teaminternet02_3ph%26channel%3Dbucket057%252Cbucket041%26hl%3Dko%26adtest%3Doff%26type%3D3%26optimize_terms%3Don%26drid%3Das-drid-2381679900993928%26uiopt%3Dfalse%26oe%3DUTF-8%26ie%3DUTF-8%26format%3Dr10%257Cs%26adrep%3D0%26num%3D0%26output%3Dcaf%2";
            string str4 = "http://dp.g.doubleclick.net/apps/domainpark/domainpark.cgi?max_radlink_len=40&r=m&fexp=21404&client=dp-teaminternet02_3ph&channel=bucket057%2Cbucket041&hl=ko&adtest=off&type=0&optimize_terms=on&drid=as-drid-2381679900993928&uiopt=false&q=%EC%98%81%EC%96%B4&afdt=CusBChMI9fCa0_qIzQIVTXu9Ch3TxwYIGAEgAFChyMkFUI3AzglQ3sK3DlC3nvIOUOXp3w9Qq5a5EFC22OAnUPm61y9Q7_u_OVD8xdY5UJmk3DlQ6O-zOlD5mMs6UJnM4jpQlujtOlDe0vQ6UPjkt1BQia2TjwFQyPmUlQFQ2ZzulwFQ_pzulwFQiJ7ulwFQtJ_ulwFQps7qpwFQnpmyvAFQsp-54wFQzKHljgJQ7rL2hgVQn5GK4QZQ4tyswgdxJn--zm2i-QqCARMI__6c0_qIzQIVlx9oCh2P9wwOjQEqcbpSkQFahkWBY3eNixIZAG06ipAAFHa1y58_yZG5I7PVuwsHsgOs7g&oe=UTF-8&ie=UTF-8&format=p5&ad=a5&adrep=2&num=0&output=caf&domain_name=ww.adunet.net&v=3&allwcallad=1&adext=as1%2Csr1%2Cctc1&bsl=8&u_his=2&u_tz=540&dt=1464857308045&u_w=1920&u_h=1080&biw=1899&bih=958&psw=1899&psh=958&frm=0&uio=uv3cs1af3wi640ff2fa2st22sd16sv16sa16lt45ld30lv30sl1sr1cc1-&jsv=38910&rurl=http%3A%2F%2Fww.adunet.net%2F%3Fts%3DfENsZWFuUGVwcGVybWludEJsYWNrfHw1Y2U4NHxidWNrZXQwNTd8fGJ1Y2tldDA0MXx8NDMxMjE1MTF8fDU3NGZmMmM3ZDk1NmZ8fHwxNDY0ODU3Mjg4LjI5Njd8MzBmNTVhODA5NTE4YWUyNDM0OWU3YWZjNGIyMGVhZTllNTIwYjA5OHx8fHx8MXx8fDB8NTc0ZmYyYzhmNzUyNWZmNjE3OGI1YjU0fHx8MHx8fHx8MHwwfHx8fHx8fHx8%26query%3D%25EC%2598%2581%25EC%2596%25B4%26afdToken%3DCusBChMI9fCa0_qIzQIVTXu9Ch3TxwYIGAEgAFChyMkFUI3AzglQ3sK3DlC3nvIOUOXp3w9Qq5a5EFC22OAnUPm61y9Q7_u_OVD8xdY5UJmk3DlQ6O-zOlD5mMs6UJnM4jpQlujtOlDe0vQ6UPjkt1BQia2TjwFQyPmUlQFQ2ZzulwFQ_pzulwFQiJ7ulwFQtJ_ulwFQps7qpwFQnpmyvAFQsp-54wFQzKHljgJQ7rL2hgVQn5GK4QZQ4tyswgdxJn--zm2i-QqCARMI__6c0_qIzQIVlx9oCh2P9wwOjQEqcbpSkQFahkWBY3eNixIZAG06ipAAFHa1y58_yZG5I7PVuwsHsgOs7g&ref=http%3A%2F%2Fdp.g.doubleclick.net%2Fapps%2Fdomainpark%2Fdomainpark.cgi%3Fmax_radlink_len%3D40%26r%3Dm%26fexp%3D21404%26client%3Ddp-teaminternet02_3ph%26channel%3Dbucket057%252Cbucket041%26hl%3Dko%26adtest%3Doff%26type%3D3%26optimize_terms%3Don%26drid%3Das-drid-2381679900993928%26uiopt%3Dfalse%26oe%3DUTF-8%26ie%3DUTF-8%26format%3Dr10%257Cs%26adrep%3D0%26num%3D0%26output%3Dcaf";
            Console.WriteLine(str3.GetHashCode().ToString());
            Console.WriteLine(str4.GetHashCode().ToString());

            Console.WriteLine(Convert.ToDateTime("2017-06-10"));

            string str_ary = "a;b;c;d";
            List<string> List_ary = str_ary.Split(';').ToList();
            Console.WriteLine(List_ary.Count);

            Console.ReadLine();
        }
        public static string PointConvert(float num, int point_length)
        {
            if (num % 1 > 0)
            {
                string PointLeft_num = num.ToString().Split('.')[0];
                string PointRight_num = num.ToString().Split('.')[1];

                return PointLeft_num + (point_length > 0 ? "." : "") + (PointRight_num + "00").Substring(0, point_length);
            }
            else
                return num.ToString() + (point_length > 0 ? "." : "") + new string('0', point_length);
        }

        public static string PointConvert2(float num, int point_length)
        {
            return string.Format("{0:#0."+ new string('#', point_length) + "}", num);
        }



        public static string Long_Encode_String(long i)
        {
            if (i == 0) return Alphabet[0].ToString();
            var s = string.Empty;
            while (i > 0)
            {
                //Console.WriteLine("i % Base : " + (i % Base).ToString());
                //Console.WriteLine("i / Base : " + (i / Base).ToString());

                s += Alphabet[i % Base];
                i = i / Base;
            }
            return string.Join(string.Empty, s.Reverse());
        }

        public static long String_Decode_Long(string s)
        {
            long i = 0;
            foreach (var c in s)
            {
                //Console.WriteLine("CharArrayIndexOf(c) : " + (CharArrayIndexOf(c)).ToString());
                //Console.WriteLine("i * Base : " + (i * Base).ToString());

                i = (i * Base) + CharArrayIndexOf(c);
            }
            return i;
        }

        private static long CharArrayIndexOf(char c)
        {
            //lock (typeof(NewSeq_Helper))
            //{
                if (__CachedValueToKey.ContainsKey(c))
                {
                    return __CachedValueToKey[c];
                }
                else
                {
                    for (long i = 0; i < Alphabet.LongLength; i++)
                    {
                        if (Alphabet[i] == c)
                        {
                            __CachedValueToKey[c] = i;
                            return i;
                        }
                    }
                }
            //}
            return 0;
        }

    }
}
