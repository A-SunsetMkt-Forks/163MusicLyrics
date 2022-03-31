using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using NUnit.Framework;
using �����Ƹ����ȡ;
using static �����Ƹ����ȡ.NetEaseMusicUtils;

namespace _163MusicLyrics_Test
{
    [TestFixture]
    public class NetEaseMusicUtilsTest
    {
        private const string LYRICS_TEST_DATA =
            "{\"Sgc\":false,\"Sfy\":true,\"Qfy\":true,\"Nolyric\":false," +
            "\"Uncollected\":false,\"TransUser\":null," +
            "\"LyricUser\":{\"Id\":3651114,\"Status\":99,\"Demand\":0,\"Userid\":85756151,\"Nickname\":\"�ǳ�TwinkleStar\",\"Uptime\":0}," +
            "\"Lrc\":{\"Version\":36,\"Lyric\":\"[00:00.000] ���� : ��ͩ\n[00:01.000] ���� : ʯҳ\n[00:10.35]������ǻ��ǵ�\n[00:14.78]������ʯҳ\n[00:17.75]�缪����ʯҳ\n[00:25.81]������ͣ���ŴӺδ������ĺ�ѻ\n[00:32.21]����ҹ����˭���̻�ɲ��\n[00:37.33]��ǰ����һ��������ή�Ļ�\n[00:41.46]���� Ϩ���˵ƻ���˼�\n[00:46.85]��ҹ�������Ƕ�������˸�ŵ��΢��\n[00:52.03]��˭��˵���Ǽ����е��껪\n[00:57.38]�Ų�̫�����زŻ����������ǰ����\n[01:03.06]��������ܼǵõĻ�\n[01:09.87]�ֱ߷��ž�ʱ�����Щ��������\n[01:14.64]ɭ�����ܲ�ʢ����������\n[01:19.62]�������ж���������ˮ����\n[01:23.74]��� �ഺ����˭��ͯ��\n[01:29.65]�¶����껪����Ҳ�����������ų���\n[01:34.89]������һ������ļ�������\n[01:40.24]ֻ����׷Ѱ����ִ�������СС����\n[01:45.88]��������ܼǵõĻ�\n\"}," +
            "\"Klyric\":{\"Version\":0,\"lyric\":\"\"},\"Tlyric\":{\"Version\":0,\"Lyric\":\"\"},\"Code\":200}";

        private const string DETAILS_TEST_DATA =
            "{\"Songs\":[{\"Name\":\"��������ܼǵ�(Vocaloid)\",\"Id\":447309968,\"Pst\":0,\"T\":0," +
            "\"Ar\":[{\"Id\":12200045,\"Name\":\"ʯҳ\",\"Tns\":[],\"Alias\":[]}],\"Alia\":[],\"Pop\":75.0,\"St\":0," +
            "\"Rt\":null,\"Fee\":0,\"V\":103,\"Crbt\":null,\"Cf\":\"\",\"Al\":{\"Id\":35060085,\"Name\":\"ʯҳ��V����\"," +
            "\"PicUrl\":\"https://p4.music.126.net/CUMANQGhUXEjB-Db1CvSwQ==/109951162824061491.jpg\",\"Tns\":[]," +
            "\"Pic\":109951162824061491},\"Dt\":157506,\"H\":{\"Br\":320000,\"Fid\":0,\"Size\":6302868,\"Vd\":-11799.0}," +
            "\"M\":{\"Br\":192000,\"Fid\":0,\"Size\":3781738,\"Vd\":-9400.0},\"L\":{\"Br\":128000,\"Fid\":0," +
            "\"Size\":2521173,\"Vd\":-8100.0},\"A\":null,\"Cd\":\"01\",\"No\":1,\"RtUrl\":null,\"Ftype\":0," +
            "\"RtUrls\":[],\"Rurl\":null,\"Rtype\":0,\"Mst\":9,\"Cp\":0,\"Mv\":0,\"PublishTime\":1481880909423," +
            "\"Privilege\":null}],\"Privileges\":[{\"Id\":447309968,\"Fee\":0,\"Payed\":0,\"St\":0,\"Pl\":320000," +
            "\"Dl\":999000,\"Sp\":7,\"Cp\":1,\"Subp\":1,\"Cs\":false,\"Maxbr\":999000,\"Fl\":320000,\"Toast\":false," +
            "\"Flag\":2}],\"Code\":200}";

        [Test]
        public void CheckInputIdAndInputIsNuber()
        {
            Assert.AreEqual(1, CheckInputId("1", out var output_1));
            Assert.AreEqual(ErrorMsg.SUCCESS, output_1);
            Assert.AreEqual(0, NetEaseMusicUtils.CheckInputId(string.Empty, out var output_2));
            Assert.AreEqual(ErrorMsg.INPUT_ID_ILLEGAG, output_2);
            Assert.AreEqual(0, NetEaseMusicUtils.CheckInputId(null, out var output_3));
            Assert.AreEqual(ErrorMsg.INPUT_ID_ILLEGAG, output_3);
        }

        [Test]
        public void CheckInputIdAndInputNotIsNuber()
        {
            Assert.AreEqual(0, CheckInputId("abc", out var output_1));
            Assert.AreEqual(ErrorMsg.INPUT_ID_ILLEGAG, output_1);
        }

        [Test]
        public void GetLyricVoThrowException()
        {
            var search = new SearchInfo();
            var lyrics = new LyricResult();

            //�Ⱥϲ���
            //Assert.Throws<ArgumentNullException>(() => GetLyricVo(null, 0, null, out _));
            //Assert.Throws<ArgumentNullException>(() => GetLyricVo(null, 0, search, out _));
            //Assert.Throws<ArgumentNullException>(() => GetLyricVo(lyrics, 0, null, out _));
            Assert.DoesNotThrow(() => GetLyricVo(lyrics, 0, search, out _));
        }

        [Test]
        public void GetLyricVoResult()
        {
            //var rawLyrics = JsonConvert.DeserializeObject<LyricResult>(TEST_DATA);
            //var lyricVo = GetLyricVo(rawLyrics, 0, null, out _);
        }

        [Test]
        public void GetOutputNameTest()
        {
            var songVo = new SongVo()
            {
                Name = "name",
                Singer = "singer"
            };
            Assert.AreEqual("name - singer", 
                GetOutputName(songVo, new SearchInfo() { OutputFileNameType = OUTPUT_FILENAME_TYPE_ENUM.NAME_SINGER }));
            Assert.AreEqual("singer - name", 
                GetOutputName(songVo, new SearchInfo() { OutputFileNameType = OUTPUT_FILENAME_TYPE_ENUM.SINGER_NAME }));
            Assert.AreEqual("name",
                GetOutputName(songVo, new SearchInfo() { OutputFileNameType = OUTPUT_FILENAME_TYPE_ENUM.NAME }));
        }

        [Test]
        public void ContractSingerTest()
        {
            var rawDetails = JsonConvert.DeserializeObject<DetailResult>(DETAILS_TEST_DATA);

            var details = new DetailResult();
            details.Songs = new Song[1];
            details.Songs[0] = new Song() { Ar = new List<Ar>() };
            details.Songs[0].Ar.Add(new Ar() { Name = "name-1"});
            details.Songs[0].Ar.Add(new Ar() { Name = "name-2"});

            Assert.AreEqual("ʯҳ", ContractSinger(rawDetails.Songs[0].Ar));
            Assert.AreEqual("name-1,name-2", ContractSinger(details.Songs[0].Ar));
            Assert.AreEqual(string.Empty, ContractSinger(new List<Ar>()));
        }

        [Test]
        public void ContractSingerException()
        {
            Assert.Throws<ArgumentNullException>(() => ContractSinger(null));
        }
    }
}