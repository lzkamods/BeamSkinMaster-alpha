using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using BeamSkinMaster.classes;
using Windows.Storage;
using System.Xml.Linq;
using System.Text.Json.Nodes;
using Microsoft.UI.Xaml.Media.Animation;
using System.Security.Cryptography.X509Certificates;

// To learn more about WinUI, the WinUI project structure,
// and more about our project autobellolates, see: http://aka.ms/winui-project-info.

namespace BeamSkinMaster.pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ChoosingNamePage : Page
    {
        public ChoosingNamePage()
        {
            this.InitializeComponent();
        }

        public static string mwpath = MainWindow.pppth;
        public static string inttxt;
        public static string namepathh;

        private async void namedalee_Click(object sender, RoutedEventArgs e)
        {
            string inttext = inttextbox.Text;
            inttxt = inttext;
            string exttext = exttextbox.Text;
            string namepath = System.IO.Path.Combine(MainWindow.pppth, inttext);
            Directory.CreateDirectory(namepath);
            namepathh = namepath;

            string imgfile = MainWindow.intauto + "_skin_SKINNAME.dds";
            string imgfileph = "/" + MainWindow.intauto + "_skin_" + inttextbox.Text + ".dds";
            string imgfilepath = namepath + imgfileph;
            string imgpath = System.IO.Path.Combine(MainWindow.pppth, imgfile);
            File.Move(imgpath, imgfilepath);

            if(MainWindow.endtext == "etk800")
            {
                string etk800stpc = "/" + "SKINNAME.pc";
                string etk800stinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + etk800stpc;
                string stinfoph = mwpath + etk800stinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string etk800pcph = mwpath + pcfile;
                string etk800infoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/etk800/etk800.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/etk800/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/etk800/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/etk800/info_SKINNAME.json");
                StorageFile etk800jbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile etk800matfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile etk800pcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile etk800infofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder etk800jbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etk800matpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etk800pcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder etk800infopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await etk800jbeamfile.CopyAsync(etk800jbeampath);
                await etk800matfile.CopyAsync(etk800matpath);
                await etk800pcfile.CopyAsync(etk800pcpath);
                await etk800infofile.CopyAsync(etk800infopath);
                File.Move(stpcph, etk800pcph);
                File.Move(stinfoph, etk800infoph);

                string etk800jbpath = namepath + "/" + "etk800.jbeam";
                string etk800jb = File.ReadAllText(etk800jbpath);
                etk800jb = etk800jb.Replace("SKINNAME", inttext);
                etk800jb = etk800jb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(etk800jbpath, etk800jb);

                string etk800matpathh = namepath + "/" + "materials.json";
                string etk800mat = File.ReadAllText(etk800matpathh);
                etk800mat = etk800mat.Replace("SKINNAME", inttext);
                File.WriteAllText(etk800matpathh, etk800mat);

                string etk800pcpathh = mwpath + pcfile;
                string etk800pc = File.ReadAllText(etk800pcpathh);
                etk800pc = etk800pc.Replace("SKINNAME", inttext);
                File.WriteAllText(etk800pcpathh, etk800pc);

                string etk800infopathh = mwpath + infofile;
                string etk800infoo = File.ReadAllText(etk800infopathh);
                etk800infoo = etk800infoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(etk800infopathh, etk800infoo);
            }

            if (MainWindow.endtext == "autobello")
            {
                string autobellostpc = "/" + "SKINNAME.pc";
                string autobellostinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + autobellostpc;
                string stinfoph = mwpath + autobellostinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string autobellopcph = mwpath + pcfile;
                string autobelloinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/autobello/autobello.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/autobello/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/autobello/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/autobello/info_SKINNAME.json");
                StorageFile autobellojbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile autobellomatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile autobellopcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile autobelloinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder autobellojbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder autobellomatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder autobellopcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder autobelloinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await autobellojbeamfile.CopyAsync(autobellojbeampath);
                await autobellomatfile.CopyAsync(autobellomatpath);
                await autobellopcfile.CopyAsync(autobellopcpath);
                await autobelloinfofile.CopyAsync(autobelloinfopath);
                File.Move(stpcph, autobellopcph);
                File.Move(stinfoph, autobelloinfoph);

                string autobellojbpath = namepath + "/" + "autobello.jbeam";
                string autobellojb = File.ReadAllText(autobellojbpath);
                autobellojb = autobellojb.Replace("SKINNAME", inttext);
                autobellojb = autobellojb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(autobellojbpath, autobellojb);

                string autobellomatpathh = namepath + "/" + "materials.json";
                string autobellomat = File.ReadAllText(autobellomatpathh);
                autobellomat = autobellomat.Replace("SKINNAME", inttext);
                File.WriteAllText(autobellomatpathh, autobellomat);

                string autobellopcpathh = mwpath + pcfile;
                string autobellopc = File.ReadAllText(autobellopcpathh);
                autobellopc = autobellopc.Replace("SKINNAME", inttext);
                File.WriteAllText(autobellopcpathh, autobellopc);

                string autobelloinfopathh = mwpath + infofile;
                string autobelloinfoo = File.ReadAllText(autobelloinfopathh);
                autobelloinfoo = autobelloinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(autobelloinfopathh, autobelloinfoo);
            }

            if (MainWindow.endtext == "midtruck")
            {
                string midtruckstpc = "/" + "SKINNAME.pc";
                string midtruckstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + midtruckstpc;
                string stinfoph = mwpath + midtruckstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string midtruckpcph = mwpath + pcfile;
                string midtruckinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/midtruck/midtruck.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/midtruck/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/midtruck/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/midtruck/info_SKINNAME.json");
                StorageFile midtruckjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile midtruckmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile midtruckpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile midtruckinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder midtruckjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder midtruckmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder midtruckpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder midtruckinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await midtruckjbeamfile.CopyAsync(midtruckjbeampath);
                await midtruckmatfile.CopyAsync(midtruckmatpath);
                await midtruckpcfile.CopyAsync(midtruckpcpath);
                await midtruckinfofile.CopyAsync(midtruckinfopath);
                File.Move(stpcph, midtruckpcph);
                File.Move(stinfoph, midtruckinfoph);

                string midtruckjbpath = namepath + "/" + "midtruck.jbeam";
                string midtruckjb = File.ReadAllText(midtruckjbpath);
                midtruckjb = midtruckjb.Replace("SKINNAME", inttext);
                midtruckjb = midtruckjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(midtruckjbpath, midtruckjb);

                string midtruckmatpathh = namepath + "/" + "materials.json";
                string midtruckmat = File.ReadAllText(midtruckmatpathh);
                midtruckmat = midtruckmat.Replace("SKINNAME", inttext);
                File.WriteAllText(midtruckmatpathh, midtruckmat);

                string midtruckpcpathh = mwpath + pcfile;
                string midtruckpc = File.ReadAllText(midtruckpcpathh);
                midtruckpc = midtruckpc.Replace("SKINNAME", inttext);
                File.WriteAllText(midtruckpcpathh, midtruckpc);

                string midtruckinfopathh = mwpath + infofile;
                string midtruckinfoo = File.ReadAllText(midtruckinfopathh);
                midtruckinfoo = midtruckinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(midtruckinfopathh, midtruckinfoo);
            }

            if (MainWindow.endtext == "bastion")
            {
                string bastionstpc = "/" + "SKINNAME.pc";
                string bastionstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + bastionstpc;
                string stinfoph = mwpath + bastionstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string bastionpcph = mwpath + pcfile;
                string bastioninfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/bastion/bastion.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/bastion/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/bastion/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/bastion/info_SKINNAME.json");
                StorageFile bastionjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile bastionmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile bastionpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile bastioninfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder bastionjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bastionmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bastionpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder bastioninfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await bastionjbeamfile.CopyAsync(bastionjbeampath);
                await bastionmatfile.CopyAsync(bastionmatpath);
                await bastionpcfile.CopyAsync(bastionpcpath);
                await bastioninfofile.CopyAsync(bastioninfopath);
                File.Move(stpcph, bastionpcph);
                File.Move(stinfoph, bastioninfoph);

                string bastionjbpath = namepath + "/" + "bastion.jbeam";
                string bastionjb = File.ReadAllText(bastionjbpath);
                bastionjb = bastionjb.Replace("SKINNAME", inttext);
                bastionjb = bastionjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(bastionjbpath, bastionjb);

                string bastionmatpathh = namepath + "/" + "materials.json";
                string bastionmat = File.ReadAllText(bastionmatpathh);
                bastionmat = bastionmat.Replace("SKINNAME", inttext);
                File.WriteAllText(bastionmatpathh, bastionmat);

                string bastionpcpathh = mwpath + pcfile;
                string bastionpc = File.ReadAllText(bastionpcpathh);
                bastionpc = bastionpc.Replace("SKINNAME", inttext);
                File.WriteAllText(bastionpcpathh, bastionpc);

                string bastioninfopathh = mwpath + infofile;
                string bastioninfoo = File.ReadAllText(bastioninfopathh);
                bastioninfoo = bastioninfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(bastioninfopathh, bastioninfoo);
            }

            if (MainWindow.endtext == "legran")
            {
                string legranstpc = "/" + "SKINNAME.pc";
                string legranstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + legranstpc;
                string stinfoph = mwpath + legranstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string legranpcph = mwpath + pcfile;
                string legraninfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/legran/legran.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/legran/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/legran/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/legran/info_SKINNAME.json");
                StorageFile legranjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile legranmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile legranpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile legraninfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder legranjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder legranmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder legranpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder legraninfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await legranjbeamfile.CopyAsync(legranjbeampath);
                await legranmatfile.CopyAsync(legranmatpath);
                await legranpcfile.CopyAsync(legranpcpath);
                await legraninfofile.CopyAsync(legraninfopath);
                File.Move(stpcph, legranpcph);
                File.Move(stinfoph, legraninfoph);

                string legranjbpath = namepath + "/" + "legran.jbeam";
                string legranjb = File.ReadAllText(legranjbpath);
                legranjb = legranjb.Replace("SKINNAME", inttext);
                legranjb = legranjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(legranjbpath, legranjb);

                string legranmatpathh = namepath + "/" + "materials.json";
                string legranmat = File.ReadAllText(legranmatpathh);
                legranmat = legranmat.Replace("SKINNAME", inttext);
                File.WriteAllText(legranmatpathh, legranmat);

                string legranpcpathh = mwpath + pcfile;
                string legranpc = File.ReadAllText(legranpcpathh);
                legranpc = legranpc.Replace("SKINNAME", inttext);
                File.WriteAllText(legranpcpathh, legranpc);

                string legraninfopathh = mwpath + infofile;
                string legraninfoo = File.ReadAllText(legraninfopathh);
                legraninfoo = legraninfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(legraninfopathh, legraninfoo);
            }

            if (MainWindow.endtext == "burnside")
            {
                string burnsidestpc = "/" + "SKINNAME.pc";
                string burnsidestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + burnsidestpc;
                string stinfoph = mwpath + burnsidestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string burnsidepcph = mwpath + pcfile;
                string burnsideinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/burnside/burnside.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/burnside/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/burnside/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/burnside/info_SKINNAME.json");
                StorageFile burnsidejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile burnsidematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile burnsidepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile burnsideinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder burnsidejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder burnsidematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder burnsidepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder burnsideinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await burnsidejbeamfile.CopyAsync(burnsidejbeampath);
                await burnsidematfile.CopyAsync(burnsidematpath);
                await burnsidepcfile.CopyAsync(burnsidepcpath);
                await burnsideinfofile.CopyAsync(burnsideinfopath);
                File.Move(stpcph, burnsidepcph);
                File.Move(stinfoph, burnsideinfoph);

                string burnsidejbpath = namepath + "/" + "burnside.jbeam";
                string burnsidejb = File.ReadAllText(burnsidejbpath);
                burnsidejb = burnsidejb.Replace("SKINNAME", inttext);
                burnsidejb = burnsidejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(burnsidejbpath, burnsidejb);

                string burnsidematpathh = namepath + "/" + "materials.json";
                string burnsidemat = File.ReadAllText(burnsidematpathh);
                burnsidemat = burnsidemat.Replace("SKINNAME", inttext);
                File.WriteAllText(burnsidematpathh, burnsidemat);

                string burnsidepcpathh = mwpath + pcfile;
                string burnsidepc = File.ReadAllText(burnsidepcpathh);
                burnsidepc = burnsidepc.Replace("SKINNAME", inttext);
                File.WriteAllText(burnsidepcpathh, burnsidepc);

                string burnsideinfopathh = mwpath + infofile;
                string burnsideinfoo = File.ReadAllText(burnsideinfopathh);
                burnsideinfoo = burnsideinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(burnsideinfopathh, burnsideinfoo);
            }

            if (MainWindow.endtext == "vivace")
            {
                string vivacestpc = "/" + "SKINNAME.pc";
                string vivacestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + vivacestpc;
                string stinfoph = mwpath + vivacestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string vivacepcph = mwpath + pcfile;
                string vivaceinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/vivace/vivace.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/vivace/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/vivace/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/vivace/info_SKINNAME.json");
                StorageFile vivacejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile vivacematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile vivacepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile vivaceinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder vivacejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder vivacematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder vivacepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder vivaceinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await vivacejbeamfile.CopyAsync(vivacejbeampath);
                await vivacematfile.CopyAsync(vivacematpath);
                await vivacepcfile.CopyAsync(vivacepcpath);
                await vivaceinfofile.CopyAsync(vivaceinfopath);
                File.Move(stpcph, vivacepcph);
                File.Move(stinfoph, vivaceinfoph);

                string vivacejbpath = namepath + "/" + "vivace.jbeam";
                string vivacejb = File.ReadAllText(vivacejbpath);
                vivacejb = vivacejb.Replace("SKINNAME", inttext);
                vivacejb = vivacejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(vivacejbpath, vivacejb);

                string vivacematpathh = namepath + "/" + "materials.json";
                string vivacemat = File.ReadAllText(vivacematpathh);
                vivacemat = vivacemat.Replace("SKINNAME", inttext);
                File.WriteAllText(vivacematpathh, vivacemat);

                string vivacepcpathh = mwpath + pcfile;
                string vivacepc = File.ReadAllText(vivacepcpathh);
                vivacepc = vivacepc.Replace("SKINNAME", inttext);
                File.WriteAllText(vivacepcpathh, vivacepc);

                string vivaceinfopathh = mwpath + infofile;
                string vivaceinfoo = File.ReadAllText(vivaceinfopathh);
                vivaceinfoo = vivaceinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(vivaceinfopathh, vivaceinfoo);
            }

            if (MainWindow.endtext == "bolide")
            {
                string bolidestpc = "/" + "SKINNAME.pc";
                string bolidestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + bolidestpc;
                string stinfoph = mwpath + bolidestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string bolidepcph = mwpath + pcfile;
                string bolideinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/bolide/bolide.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/bolide/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/bolide/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/bolide/info_SKINNAME.json");
                StorageFile bolidejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile bolidematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile bolidepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile bolideinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder bolidejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bolidematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bolidepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder bolideinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await bolidejbeamfile.CopyAsync(bolidejbeampath);
                await bolidematfile.CopyAsync(bolidematpath);
                await bolidepcfile.CopyAsync(bolidepcpath);
                await bolideinfofile.CopyAsync(bolideinfopath);
                File.Move(stpcph, bolidepcph);
                File.Move(stinfoph, bolideinfoph);

                string bolidejbpath = namepath + "/" + "bolide.jbeam";
                string bolidejb = File.ReadAllText(bolidejbpath);
                bolidejb = bolidejb.Replace("SKINNAME", inttext);
                bolidejb = bolidejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(bolidejbpath, bolidejb);

                string bolidematpathh = namepath + "/" + "materials.json";
                string bolidemat = File.ReadAllText(bolidematpathh);
                bolidemat = bolidemat.Replace("SKINNAME", inttext);
                File.WriteAllText(bolidematpathh, bolidemat);

                string bolidepcpathh = mwpath + pcfile;
                string bolidepc = File.ReadAllText(bolidepcpathh);
                bolidepc = bolidepc.Replace("SKINNAME", inttext);
                File.WriteAllText(bolidepcpathh, bolidepc);

                string bolideinfopathh = mwpath + infofile;
                string bolideinfoo = File.ReadAllText(bolideinfopathh);
                bolideinfoo = bolideinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(bolideinfopathh, bolideinfoo);
            }

            try
            {
                if (MainWindow.endtext == "scintilla")
                {
                    string scintillastpc = "/" + "SKINNAME.pc";
                    string scintillastinfo = "/" + "info_SKINNAME.json";
                    string stpcph = mwpath + scintillastpc;
                    string stinfoph = mwpath + scintillastinfo;
                    string pcfile = "/" + inttext + ".pc";
                    string infofile = "/" + "info_" + inttext + ".json";
                    string scintillapcph = mwpath + pcfile;
                    string scintillainfoph = mwpath + infofile;

                    Uri scintillajbeamuri = new Uri($"ms-appx:///Assets/text_files/scintilla/scintilla.jbeam");
                    Uri scintillamaturi = new Uri($"ms-appx:///Assets/text_files/scintilla/materials.json");
                    Uri scintillapcuri = new Uri($"ms-appx:///Assets/text_files/scintilla/SKINNAME.pc");
                    Uri scintillainfouri = new Uri($"ms-appx:///Assets/text_files/scintilla/info_SKINNAME.json");
                    StorageFile scintillajbeamfile = await StorageFile.GetFileFromApplicationUriAsync(scintillajbeamuri);
                    StorageFile scintillamatfile = await StorageFile.GetFileFromApplicationUriAsync(scintillamaturi);
                    StorageFile scintillapcfile = await StorageFile.GetFileFromApplicationUriAsync(scintillapcuri);
                    StorageFile scintillainfofile = await StorageFile.GetFileFromApplicationUriAsync(scintillainfouri);

                    StorageFolder scintillajbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                    StorageFolder scintillamatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                    StorageFolder scintillapcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                    StorageFolder scintillainfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                    await scintillajbeamfile.CopyAsync(scintillajbeampath);
                    await scintillamatfile.CopyAsync(scintillamatpath);
                    await scintillapcfile.CopyAsync(scintillapcpath);
                    await scintillainfofile.CopyAsync(scintillainfopath);
                    File.Move(stpcph, scintillapcph);
                    File.Move(stinfoph, scintillainfoph);

                    string scintillajbpath = namepath + "/" + "scintilla.jbeam";
                    string scintillajb = File.ReadAllText(scintillajbpath);
                    scintillajb = scintillajb.Replace("SKINNAME", inttext);
                    scintillajb = scintillajb.Replace("YOUR SKIN NAME", exttext);
                    File.WriteAllText(scintillajbpath, scintillajb);

                    string scintillamatpathh = namepath + "/" + "materials.json";
                    string scintillamat = File.ReadAllText(scintillamatpathh);
                    scintillamat = scintillamat.Replace("SKINNAME", inttext);
                    File.WriteAllText(scintillamatpathh, scintillamat);

                    string scintillapcpathh = mwpath + pcfile;
                    string scintillapc = File.ReadAllText(scintillapcpathh);
                    scintillapc = scintillapc.Replace("SKINNAME", inttext);
                    File.WriteAllText(scintillapcpathh, scintillapc);

                    string scintillainfopathh = mwpath + infofile;
                    string scintillainfoo = File.ReadAllText(scintillainfopathh);
                    scintillainfoo = scintillainfoo.Replace("SKIN NAME", exttext);
                    File.WriteAllText(scintillainfopathh, scintillainfoo);
                }
            }

            catch (Exception ex)
            {
                ContentDialog error = new ContentDialog
                {
                    Title = "Ошибка при перемещнии",
                    Content = $"Невозможно переместить папку, по причине: {ex.Message}",
                    CloseButtonText = "OK",
                };
                error.XamlRoot = exttextbox.XamlRoot;

                ContentDialogResult result = await error.ShowAsync();
            }

            if (MainWindow.endtext == "etki")
            {
                string etkistpc = "/" + "SKINNAME.pc";
                string etkistinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + etkistpc;
                string stinfoph = mwpath + etkistinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string etkipcph = mwpath + pcfile;
                string etkiinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/etki/etki.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/etki/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/etki/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/etki/info_SKINNAME.json");
                StorageFile etkijbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile etkimatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile etkipcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile etkiinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder etkijbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etkimatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etkipcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder etkiinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await etkijbeamfile.CopyAsync(etkijbeampath);
                await etkimatfile.CopyAsync(etkimatpath);
                await etkipcfile.CopyAsync(etkipcpath);
                await etkiinfofile.CopyAsync(etkiinfopath);
                File.Move(stpcph, etkipcph);
                File.Move(stinfoph, etkiinfoph);

                string etkijbpath = namepath + "/" + "etki.jbeam";
                string etkijb = File.ReadAllText(etkijbpath);
                etkijb = etkijb.Replace("SKINNAME", inttext);
                etkijb = etkijb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(etkijbpath, etkijb);

                string etkimatpathh = namepath + "/" + "materials.json";
                string etkimat = File.ReadAllText(etkimatpathh);
                etkimat = etkimat.Replace("SKINNAME", inttext);
                File.WriteAllText(etkimatpathh, etkimat);

                string etkipcpathh = mwpath + pcfile;
                string etkipc = File.ReadAllText(etkipcpathh);
                etkipc = etkipc.Replace("SKINNAME", inttext);
                File.WriteAllText(etkipcpathh, etkipc);

                string etkiinfopathh = mwpath + infofile;
                string etkiinfoo = File.ReadAllText(etkiinfopathh);
                etkiinfoo = etkiinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(etkiinfopathh, etkiinfoo);
            }

            if (MainWindow.endtext == "etkc")
            {
                string etkcstpc = "/" + "SKINNAME.pc";
                string etkcstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + etkcstpc;
                string stinfoph = mwpath + etkcstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string etkcpcph = mwpath + pcfile;
                string etkcinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/etkc/etkc.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/etkc/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/etkc/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/etkc/info_SKINNAME.json");
                StorageFile etkcjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile etkcmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile etkcpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile etkcinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder etkcjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etkcmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder etkcpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder etkcinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await etkcjbeamfile.CopyAsync(etkcjbeampath);
                await etkcmatfile.CopyAsync(etkcmatpath);
                await etkcpcfile.CopyAsync(etkcpcpath);
                await etkcinfofile.CopyAsync(etkcinfopath);
                File.Move(stpcph, etkcpcph);
                File.Move(stinfoph, etkcinfoph);

                string etkcjbpath = namepath + "/" + "etkc.jbeam";
                string etkcjb = File.ReadAllText(etkcjbpath);
                etkcjb = etkcjb.Replace("SKINNAME", inttext);
                etkcjb = etkcjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(etkcjbpath, etkcjb);

                string etkcmatpathh = namepath + "/" + "materials.json";
                string etkcmat = File.ReadAllText(etkcmatpathh);
                etkcmat = etkcmat.Replace("SKINNAME", inttext);
                File.WriteAllText(etkcmatpathh, etkcmat);

                string etkcpcpathh = mwpath + pcfile;
                string etkcpc = File.ReadAllText(etkcpcpathh);
                etkcpc = etkcpc.Replace("SKINNAME", inttext);
                File.WriteAllText(etkcpcpathh, etkcpc);

                string etkcinfopathh = mwpath + infofile;
                string etkcinfoo = File.ReadAllText(etkcinfopathh);
                etkcinfoo = etkcinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(etkcinfopathh, etkcinfoo);
            }

            if (MainWindow.endtext == "barstow")
            {
                string barstowstpc = "/" + "SKINNAME.pc";
                string barstowstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + barstowstpc;
                string stinfoph = mwpath + barstowstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string barstowpcph = mwpath + pcfile;
                string barstowinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/barstow/barstow.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/barstow/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/barstow/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/barstow/info_SKINNAME.json");
                StorageFile barstowjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile barstowmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile barstowpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile barstowinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder barstowjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder barstowmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder barstowpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder barstowinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await barstowjbeamfile.CopyAsync(barstowjbeampath);
                await barstowmatfile.CopyAsync(barstowmatpath);
                await barstowpcfile.CopyAsync(barstowpcpath);
                await barstowinfofile.CopyAsync(barstowinfopath);
                File.Move(stpcph, barstowpcph);
                File.Move(stinfoph, barstowinfoph);

                string barstowjbpath = namepath + "/" + "barstow.jbeam";
                string barstowjb = File.ReadAllText(barstowjbpath);
                barstowjb = barstowjb.Replace("SKINNAME", inttext);
                barstowjb = barstowjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(barstowjbpath, barstowjb);

                string barstowmatpathh = namepath + "/" + "materials.json";
                string barstowmat = File.ReadAllText(barstowmatpathh);
                barstowmat = barstowmat.Replace("SKINNAME", inttext);
                File.WriteAllText(barstowmatpathh, barstowmat);

                string barstowpcpathh = mwpath + pcfile;
                string barstowpc = File.ReadAllText(barstowpcpathh);
                barstowpc = barstowpc.Replace("SKINNAME", inttext);
                File.WriteAllText(barstowpcpathh, barstowpc);

                string barstowinfopathh = mwpath + infofile;
                string barstowinfoo = File.ReadAllText(barstowinfopathh);
                barstowinfoo = barstowinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(barstowinfopathh, barstowinfoo);
            }

            if (MainWindow.endtext == "bluebuck")
            {
                string bluebuckstpc = "/" + "SKINNAME.pc";
                string bluebuckstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + bluebuckstpc;
                string stinfoph = mwpath + bluebuckstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string bluebuckpcph = mwpath + pcfile;
                string bluebuckinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/bluebuck/bluebuck.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/bluebuck/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/bluebuck/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/bluebuck/info_SKINNAME.json");
                StorageFile bluebuckjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile bluebuckmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile bluebuckpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile bluebuckinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder bluebuckjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bluebuckmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder bluebuckpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder bluebuckinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await bluebuckjbeamfile.CopyAsync(bluebuckjbeampath);
                await bluebuckmatfile.CopyAsync(bluebuckmatpath);
                await bluebuckpcfile.CopyAsync(bluebuckpcpath);
                await bluebuckinfofile.CopyAsync(bluebuckinfopath);
                File.Move(stpcph, bluebuckpcph);
                File.Move(stinfoph, bluebuckinfoph);

                string bluebuckjbpath = namepath + "/" + "bluebuck.jbeam";
                string bluebuckjb = File.ReadAllText(bluebuckjbpath);
                bluebuckjb = bluebuckjb.Replace("SKINNAME", inttext);
                bluebuckjb = bluebuckjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(bluebuckjbpath, bluebuckjb);

                string bluebuckmatpathh = namepath + "/" + "materials.json";
                string bluebuckmat = File.ReadAllText(bluebuckmatpathh);
                bluebuckmat = bluebuckmat.Replace("SKINNAME", inttext);
                File.WriteAllText(bluebuckmatpathh, bluebuckmat);

                string bluebuckpcpathh = mwpath + pcfile;
                string bluebuckpc = File.ReadAllText(bluebuckpcpathh);
                bluebuckpc = bluebuckpc.Replace("SKINNAME", inttext);
                File.WriteAllText(bluebuckpcpathh, bluebuckpc);

                string bluebuckinfopathh = mwpath + infofile;
                string bluebuckinfoo = File.ReadAllText(bluebuckinfopathh);
                bluebuckinfoo = bluebuckinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(bluebuckinfopathh, bluebuckinfoo);
            }

            if (MainWindow.endtext == "pickup")
            {
                string pickupstpc = "/" + "SKINNAME.pc";
                string pickupstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + pickupstpc;
                string stinfoph = mwpath + pickupstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string pickuppcph = mwpath + pcfile;
                string pickupinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/pickup/pickup.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/pickup/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/pickup/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/pickup/info_SKINNAME.json");
                StorageFile pickupjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile pickupmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile pickuppcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile pickupinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder pickupjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pickupmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pickuppcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder pickupinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await pickupjbeamfile.CopyAsync(pickupjbeampath);
                await pickupmatfile.CopyAsync(pickupmatpath);
                await pickuppcfile.CopyAsync(pickuppcpath);
                await pickupinfofile.CopyAsync(pickupinfopath);
                File.Move(stpcph, pickuppcph);
                File.Move(stinfoph, pickupinfoph);

                string pickupjbpath = namepath + "/" + "pickup.jbeam";
                string pickupjb = File.ReadAllText(pickupjbpath);
                pickupjb = pickupjb.Replace("SKINNAME", inttext);
                pickupjb = pickupjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(pickupjbpath, pickupjb);

                string pickupmatpathh = namepath + "/" + "materials.json";
                string pickupmat = File.ReadAllText(pickupmatpathh);
                pickupmat = pickupmat.Replace("SKINNAME", inttext);
                File.WriteAllText(pickupmatpathh, pickupmat);

                string pickuppcpathh = mwpath + pcfile;
                string pickuppc = File.ReadAllText(pickuppcpathh);
                pickuppc = pickuppc.Replace("SKINNAME", inttext);
                File.WriteAllText(pickuppcpathh, pickuppc);

                string pickupinfopathh = mwpath + infofile;
                string pickupinfoo = File.ReadAllText(pickupinfopathh);
                pickupinfoo = pickupinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(pickupinfopathh, pickupinfoo);
            }

            if (MainWindow.endtext == "fullsize")
            {
                string fullsizestpc = "/" + "SKINNAME.pc";
                string fullsizestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + fullsizestpc;
                string stinfoph = mwpath + fullsizestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string fullsizepcph = mwpath + pcfile;
                string fullsizeinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/fullsize/fullsize.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/fullsize/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/fullsize/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/fullsize/info_SKINNAME.json");
                StorageFile fullsizejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile fullsizematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile fullsizepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile fullsizeinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder fullsizejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder fullsizematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder fullsizepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder fullsizeinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await fullsizejbeamfile.CopyAsync(fullsizejbeampath);
                await fullsizematfile.CopyAsync(fullsizematpath);
                await fullsizepcfile.CopyAsync(fullsizepcpath);
                await fullsizeinfofile.CopyAsync(fullsizeinfopath);
                File.Move(stpcph, fullsizepcph);
                File.Move(stinfoph, fullsizeinfoph);

                string fullsizejbpath = namepath + "/" + "fullsize.jbeam";
                string fullsizejb = File.ReadAllText(fullsizejbpath);
                fullsizejb = fullsizejb.Replace("SKINNAME", inttext);
                fullsizejb = fullsizejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(fullsizejbpath, fullsizejb);

                string fullsizematpathh = namepath + "/" + "materials.json";
                string fullsizemat = File.ReadAllText(fullsizematpathh);
                fullsizemat = fullsizemat.Replace("SKINNAME", inttext);
                File.WriteAllText(fullsizematpathh, fullsizemat);

                string fullsizepcpathh = mwpath + pcfile;
                string fullsizepc = File.ReadAllText(fullsizepcpathh);
                fullsizepc = fullsizepc.Replace("SKINNAME", inttext);
                File.WriteAllText(fullsizepcpathh, fullsizepc);

                string fullsizeinfopathh = mwpath + infofile;
                string fullsizeinfoo = File.ReadAllText(fullsizeinfopathh);
                fullsizeinfoo = fullsizeinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(fullsizeinfopathh, fullsizeinfoo);
            }

            if (MainWindow.endtext == "van")
            {
                string vanstpc = "/" + "SKINNAME.pc";
                string vanstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + vanstpc;
                string stinfoph = mwpath + vanstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string vanpcph = mwpath + pcfile;
                string vaninfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/van/van.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/van/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/van/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/van/info_SKINNAME.json");
                StorageFile vanjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile vanmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile vanpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile vaninfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder vanjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder vanmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder vanpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder vaninfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await vanjbeamfile.CopyAsync(vanjbeampath);
                await vanmatfile.CopyAsync(vanmatpath);
                await vanpcfile.CopyAsync(vanpcpath);
                await vaninfofile.CopyAsync(vaninfopath);
                File.Move(stpcph, vanpcph);
                File.Move(stinfoph, vaninfoph);

                string vanjbpath = namepath + "/" + "van.jbeam";
                string vanjb = File.ReadAllText(vanjbpath);
                vanjb = vanjb.Replace("SKINNAME", inttext);
                vanjb = vanjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(vanjbpath, vanjb);

                string vanmatpathh = namepath + "/" + "materials.json";
                string vanmat = File.ReadAllText(vanmatpathh);
                vanmat = vanmat.Replace("SKINNAME", inttext);
                File.WriteAllText(vanmatpathh, vanmat);

                string vanpcpathh = mwpath + pcfile;
                string vanpc = File.ReadAllText(vanpcpathh);
                vanpc = vanpc.Replace("SKINNAME", inttext);
                File.WriteAllText(vanpcpathh, vanpc);

                string vaninfopathh = mwpath + infofile;
                string vaninfoo = File.ReadAllText(vaninfopathh);
                vaninfoo = vaninfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(vaninfopathh, vaninfoo);
            }

            if (MainWindow.endtext == "roamer")
            {
                string roamerstpc = "/" + "SKINNAME.pc";
                string roamerstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + roamerstpc;
                string stinfoph = mwpath + roamerstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string roamerpcph = mwpath + pcfile;
                string roamerinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/roamer/roamer.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/roamer/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/roamer/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/roamer/info_SKINNAME.json");
                StorageFile roamerjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile roamermatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile roamerpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile roamerinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder roamerjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder roamermatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder roamerpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder roamerinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await roamerjbeamfile.CopyAsync(roamerjbeampath);
                await roamermatfile.CopyAsync(roamermatpath);
                await roamerpcfile.CopyAsync(roamerpcpath);
                await roamerinfofile.CopyAsync(roamerinfopath);
                File.Move(stpcph, roamerpcph);
                File.Move(stinfoph, roamerinfoph);

                string roamerjbpath = namepath + "/" + "roamer.jbeam";
                string roamerjb = File.ReadAllText(roamerjbpath);
                roamerjb = roamerjb.Replace("SKINNAME", inttext);
                roamerjb = roamerjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(roamerjbpath, roamerjb);

                string roamermatpathh = namepath + "/" + "materials.json";
                string roamermat = File.ReadAllText(roamermatpathh);
                roamermat = roamermat.Replace("SKINNAME", inttext);
                File.WriteAllText(roamermatpathh, roamermat);

                string roamerpcpathh = mwpath + pcfile;
                string roamerpc = File.ReadAllText(roamerpcpathh);
                roamerpc = roamerpc.Replace("SKINNAME", inttext);
                File.WriteAllText(roamerpcpathh, roamerpc);

                string roamerinfopathh = mwpath + infofile;
                string roamerinfoo = File.ReadAllText(roamerinfopathh);
                roamerinfoo = roamerinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(roamerinfopathh, roamerinfoo);
            }

            if (MainWindow.endtext == "semi")
            {
                string semistpc = "/" + "SKINNAME.pc";
                string semistinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + semistpc;
                string stinfoph = mwpath + semistinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string semipcph = mwpath + pcfile;
                string semiinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/semi/semi.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/semi/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/semi/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/semi/info_SKINNAME.json");
                StorageFile semijbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile semimatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile semipcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile semiinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder semijbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder semimatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder semipcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder semiinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await semijbeamfile.CopyAsync(semijbeampath);
                await semimatfile.CopyAsync(semimatpath);
                await semipcfile.CopyAsync(semipcpath);
                await semiinfofile.CopyAsync(semiinfopath);
                File.Move(stpcph, semipcph);
                File.Move(stinfoph, semiinfoph);

                string semijbpath = namepath + "/" + "semi.jbeam";
                string semijb = File.ReadAllText(semijbpath);
                semijb = semijb.Replace("SKINNAME", inttext);
                semijb = semijb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(semijbpath, semijb);

                string semimatpathh = namepath + "/" + "materials.json";
                string semimat = File.ReadAllText(semimatpathh);
                semimat = semimat.Replace("SKINNAME", inttext);
                File.WriteAllText(semimatpathh, semimat);

                string semipcpathh = mwpath + pcfile;
                string semipc = File.ReadAllText(semipcpathh);
                semipc = semipc.Replace("SKINNAME", inttext);
                File.WriteAllText(semipcpathh, semipc);

                string semiinfopathh = mwpath + infofile;
                string semiinfoo = File.ReadAllText(semiinfopathh);
                semiinfoo = semiinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(semiinfopathh, semiinfoo);
            }

            if (MainWindow.endtext == "sbr")
            {
                string sbrstpc = "/" + "SKINNAME.pc";
                string sbrstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + sbrstpc;
                string stinfoph = mwpath + sbrstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string sbrpcph = mwpath + pcfile;
                string sbrinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/sbr/sbr.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/sbr/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/sbr/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/sbr/info_SKINNAME.json");
                StorageFile sbrjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile sbrmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile sbrpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile sbrinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder sbrjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder sbrmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder sbrpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder sbrinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await sbrjbeamfile.CopyAsync(sbrjbeampath);
                await sbrmatfile.CopyAsync(sbrmatpath);
                await sbrpcfile.CopyAsync(sbrpcpath);
                await sbrinfofile.CopyAsync(sbrinfopath);
                File.Move(stpcph, sbrpcph);
                File.Move(stinfoph, sbrinfoph);

                string sbrjbpath = namepath + "/" + "sbr.jbeam";
                string sbrjb = File.ReadAllText(sbrjbpath);
                sbrjb = sbrjb.Replace("SKINNAME", inttext);
                sbrjb = sbrjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(sbrjbpath, sbrjb);

                string sbrmatpathh = namepath + "/" + "materials.json";
                string sbrmat = File.ReadAllText(sbrmatpathh);
                sbrmat = sbrmat.Replace("SKINNAME", inttext);
                File.WriteAllText(sbrmatpathh, sbrmat);

                string sbrpcpathh = mwpath + pcfile;
                string sbrpc = File.ReadAllText(sbrpcpathh);
                sbrpc = sbrpc.Replace("SKINNAME", inttext);
                File.WriteAllText(sbrpcpathh, sbrpc);

                string sbrinfopathh = mwpath + infofile;
                string sbrinfoo = File.ReadAllText(sbrinfopathh);
                sbrinfoo = sbrinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(sbrinfopathh, sbrinfoo);
            }

            if (MainWindow.endtext == "sunburst")
            {
                string sunburststpc = "/" + "SKINNAME.pc";
                string sunburststinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + sunburststpc;
                string stinfoph = mwpath + sunburststinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string sunburstpcph = mwpath + pcfile;
                string sunburstinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/sunburst/sunburst.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/sunburst/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/sunburst/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/sunburst/info_SKINNAME.json");
                StorageFile sunburstjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile sunburstmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile sunburstpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile sunburstinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder sunburstjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder sunburstmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder sunburstpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder sunburstinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await sunburstjbeamfile.CopyAsync(sunburstjbeampath);
                await sunburstmatfile.CopyAsync(sunburstmatpath);
                await sunburstpcfile.CopyAsync(sunburstpcpath);
                await sunburstinfofile.CopyAsync(sunburstinfopath);
                File.Move(stpcph, sunburstpcph);
                File.Move(stinfoph, sunburstinfoph);

                string sunburstjbpath = namepath + "/" + "sunburst.jbeam";
                string sunburstjb = File.ReadAllText(sunburstjbpath);
                sunburstjb = sunburstjb.Replace("SKINNAME", inttext);
                sunburstjb = sunburstjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(sunburstjbpath, sunburstjb);

                string sunburstmatpathh = namepath + "/" + "materials.json";
                string sunburstmat = File.ReadAllText(sunburstmatpathh);
                sunburstmat = sunburstmat.Replace("SKINNAME", inttext);
                File.WriteAllText(sunburstmatpathh, sunburstmat);

                string sunburstpcpathh = mwpath + pcfile;
                string sunburstpc = File.ReadAllText(sunburstpcpathh);
                sunburstpc = sunburstpc.Replace("SKINNAME", inttext);
                File.WriteAllText(sunburstpcpathh, sunburstpc);

                string sunburstinfopathh = mwpath + infofile;
                string sunburstinfoo = File.ReadAllText(sunburstinfopathh);
                sunburstinfoo = sunburstinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(sunburstinfopathh, sunburstinfoo);
            }

            if (MainWindow.endtext == "coupe")
            {
                string coupestpc = "/" + "SKINNAME.pc";
                string coupestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + coupestpc;
                string stinfoph = mwpath + coupestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string coupepcph = mwpath + pcfile;
                string coupeinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/coupe/coupe.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/coupe/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/coupe/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/coupe/info_SKINNAME.json");
                StorageFile coupejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile coupematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile coupepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile coupeinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder coupejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder coupematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder coupepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder coupeinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await coupejbeamfile.CopyAsync(coupejbeampath);
                await coupematfile.CopyAsync(coupematpath);
                await coupepcfile.CopyAsync(coupepcpath);
                await coupeinfofile.CopyAsync(coupeinfopath);
                File.Move(stpcph, coupepcph);
                File.Move(stinfoph, coupeinfoph);

                string coupejbpath = namepath + "/" + "coupe.jbeam";
                string coupejb = File.ReadAllText(coupejbpath);
                coupejb = coupejb.Replace("SKINNAME", inttext);
                coupejb = coupejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(coupejbpath, coupejb);

                string coupematpathh = namepath + "/" + "materials.json";
                string coupemat = File.ReadAllText(coupematpathh);
                coupemat = coupemat.Replace("SKINNAME", inttext);
                File.WriteAllText(coupematpathh, coupemat);

                string coupepcpathh = mwpath + pcfile;
                string coupepc = File.ReadAllText(coupepcpathh);
                coupepc = coupepc.Replace("SKINNAME", inttext);
                File.WriteAllText(coupepcpathh, coupepc);

                string coupeinfopathh = mwpath + infofile;
                string coupeinfoo = File.ReadAllText(coupeinfopathh);
                coupeinfoo = coupeinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(coupeinfopathh, coupeinfoo);
            }

            if (MainWindow.endtext == "covet")
            {
                string covetstpc = "/" + "SKINNAME.pc";
                string covetstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + covetstpc;
                string stinfoph = mwpath + covetstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string covetpcph = mwpath + pcfile;
                string covetinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/covet/covet.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/covet/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/covet/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/covet/info_SKINNAME.json");
                StorageFile covetjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile covetmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile covetpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile covetinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder covetjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder covetmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder covetpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder covetinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await covetjbeamfile.CopyAsync(covetjbeampath);
                await covetmatfile.CopyAsync(covetmatpath);
                await covetpcfile.CopyAsync(covetpcpath);
                await covetinfofile.CopyAsync(covetinfopath);
                File.Move(stpcph, covetpcph);
                File.Move(stinfoph, covetinfoph);

                string covetjbpath = namepath + "/" + "covet.jbeam";
                string covetjb = File.ReadAllText(covetjbpath);
                covetjb = covetjb.Replace("SKINNAME", inttext);
                covetjb = covetjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(covetjbpath, covetjb);

                string covetmatpathh = namepath + "/" + "materials.json";
                string covetmat = File.ReadAllText(covetmatpathh);
                covetmat = covetmat.Replace("SKINNAME", inttext);
                File.WriteAllText(covetmatpathh, covetmat);

                string covetpcpathh = mwpath + pcfile;
                string covetpc = File.ReadAllText(covetpcpathh);
                covetpc = covetpc.Replace("SKINNAME", inttext);
                File.WriteAllText(covetpcpathh, covetpc);

                string covetinfopathh = mwpath + infofile;
                string covetinfoo = File.ReadAllText(covetinfopathh);
                covetinfoo = covetinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(covetinfopathh, covetinfoo);
            }

            if (MainWindow.endtext == "hopper")
            {
                string hopperstpc = "/" + "SKINNAME.pc";
                string hopperstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + hopperstpc;
                string stinfoph = mwpath + hopperstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string hopperpcph = mwpath + pcfile;
                string hopperinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/hopper/hopper.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/hopper/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/hopper/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/hopper/info_SKINNAME.json");
                StorageFile hopperjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile hoppermatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile hopperpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile hopperinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder hopperjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder hoppermatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder hopperpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder hopperinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await hopperjbeamfile.CopyAsync(hopperjbeampath);
                await hoppermatfile.CopyAsync(hoppermatpath);
                await hopperpcfile.CopyAsync(hopperpcpath);
                await hopperinfofile.CopyAsync(hopperinfopath);
                File.Move(stpcph, hopperpcph);
                File.Move(stinfoph, hopperinfoph);

                string hopperjbpath = namepath + "/" + "hopper.jbeam";
                string hopperjb = File.ReadAllText(hopperjbpath);
                hopperjb = hopperjb.Replace("SKINNAME", inttext);
                hopperjb = hopperjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(hopperjbpath, hopperjb);

                string hoppermatpathh = namepath + "/" + "materials.json";
                string hoppermat = File.ReadAllText(hoppermatpathh);
                hoppermat = hoppermat.Replace("SKINNAME", inttext);
                File.WriteAllText(hoppermatpathh, hoppermat);

                string hopperpcpathh = mwpath + pcfile;
                string hopperpc = File.ReadAllText(hopperpcpathh);
                hopperpc = hopperpc.Replace("SKINNAME", inttext);
                File.WriteAllText(hopperpcpathh, hopperpc);

                string hopperinfopathh = mwpath + infofile;
                string hopperinfoo = File.ReadAllText(hopperinfopathh);
                hopperinfoo = hopperinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(hopperinfopathh, hopperinfoo);
            }

            if (MainWindow.endtext == "miramar")
            {
                string miramarstpc = "/" + "SKINNAME.pc";
                string miramarstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + miramarstpc;
                string stinfoph = mwpath + miramarstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string miramarpcph = mwpath + pcfile;
                string miramarinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/miramar/miramar.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/miramar/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/miramar/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/miramar/info_SKINNAME.json");
                StorageFile miramarjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile miramarmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile miramarpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile miramarinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder miramarjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder miramarmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder miramarpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder miramarinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await miramarjbeamfile.CopyAsync(miramarjbeampath);
                await miramarmatfile.CopyAsync(miramarmatpath);
                await miramarpcfile.CopyAsync(miramarpcpath);
                await miramarinfofile.CopyAsync(miramarinfopath);
                File.Move(stpcph, miramarpcph);
                File.Move(stinfoph, miramarinfoph);

                string miramarjbpath = namepath + "/" + "miramar.jbeam";
                string miramarjb = File.ReadAllText(miramarjbpath);
                miramarjb = miramarjb.Replace("SKINNAME", inttext);
                miramarjb = miramarjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(miramarjbpath, miramarjb);

                string miramarmatpathh = namepath + "/" + "materials.json";
                string miramarmat = File.ReadAllText(miramarmatpathh);
                miramarmat = miramarmat.Replace("SKINNAME", inttext);
                File.WriteAllText(miramarmatpathh, miramarmat);

                string miramarpcpathh = mwpath + pcfile;
                string miramarpc = File.ReadAllText(miramarpcpathh);
                miramarpc = miramarpc.Replace("SKINNAME", inttext);
                File.WriteAllText(miramarpcpathh, miramarpc);

                string miramarinfopathh = mwpath + infofile;
                string miramarinfoo = File.ReadAllText(miramarinfopathh);
                miramarinfoo = miramarinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(miramarinfopathh, miramarinfoo);
            }

            if (MainWindow.endtext == "pessima")
            {
                string pessimastpc = "/" + "SKINNAME.pc";
                string pessimastinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + pessimastpc;
                string stinfoph = mwpath + pessimastinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string pessimapcph = mwpath + pcfile;
                string pessimainfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/pessima/pessima.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/pessima/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/pessima/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/pessima/info_SKINNAME.json");
                StorageFile pessimajbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile pessimamatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile pessimapcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile pessimainfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder pessimajbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pessimamatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pessimapcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder pessimainfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await pessimajbeamfile.CopyAsync(pessimajbeampath);
                await pessimamatfile.CopyAsync(pessimamatpath);
                await pessimapcfile.CopyAsync(pessimapcpath);
                await pessimainfofile.CopyAsync(pessimainfopath);
                File.Move(stpcph, pessimapcph);
                File.Move(stinfoph, pessimainfoph);

                string pessimajbpath = namepath + "/" + "pessima.jbeam";
                string pessimajb = File.ReadAllText(pessimajbpath);
                pessimajb = pessimajb.Replace("SKINNAME", inttext);
                pessimajb = pessimajb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(pessimajbpath, pessimajb);

                string pessimamatpathh = namepath + "/" + "materials.json";
                string pessimamat = File.ReadAllText(pessimamatpathh);
                pessimamat = pessimamat.Replace("SKINNAME", inttext);
                File.WriteAllText(pessimamatpathh, pessimamat);

                string pessimapcpathh = mwpath + pcfile;
                string pessimapc = File.ReadAllText(pessimapcpathh);
                pessimapc = pessimapc.Replace("SKINNAME", inttext);
                File.WriteAllText(pessimapcpathh, pessimapc);

                string pessimainfopathh = mwpath + infofile;
                string pessimainfoo = File.ReadAllText(pessimainfopathh);
                pessimainfoo = pessimainfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(pessimainfopathh, pessimainfoo);
            }

            if (MainWindow.endtext == "midsize")
            {
                string midsizestpc = "/" + "SKINNAME.pc";
                string midsizestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + midsizestpc;
                string stinfoph = mwpath + midsizestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string midsizepcph = mwpath + pcfile;
                string midsizeinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/midsize/midsize.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/midsize/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/midsize/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/midsize/info_SKINNAME.json");
                StorageFile midsizejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile midsizematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile midsizepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile midsizeinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder midsizejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder midsizematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder midsizepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder midsizeinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await midsizejbeamfile.CopyAsync(midsizejbeampath);
                await midsizematfile.CopyAsync(midsizematpath);
                await midsizepcfile.CopyAsync(midsizepcpath);
                await midsizeinfofile.CopyAsync(midsizeinfopath);
                File.Move(stpcph, midsizepcph);
                File.Move(stinfoph, midsizeinfoph);

                string midsizejbpath = namepath + "/" + "midsize.jbeam";
                string midsizejb = File.ReadAllText(midsizejbpath);
                midsizejb = midsizejb.Replace("SKINNAME", inttext);
                midsizejb = midsizejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(midsizejbpath, midsizejb);

                string midsizematpathh = namepath + "/" + "materials.json";
                string midsizemat = File.ReadAllText(midsizematpathh);
                midsizemat = midsizemat.Replace("SKINNAME", inttext);
                File.WriteAllText(midsizematpathh, midsizemat);

                string midsizepcpathh = mwpath + pcfile;
                string midsizepc = File.ReadAllText(midsizepcpathh);
                midsizepc = midsizepc.Replace("SKINNAME", inttext);
                File.WriteAllText(midsizepcpathh, midsizepc);

                string midsizeinfopathh = mwpath + infofile;
                string midsizeinfoo = File.ReadAllText(midsizeinfopathh);
                midsizeinfoo = midsizeinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(midsizeinfopathh, midsizeinfoo);
            }

            if (MainWindow.endtext == "pigeon")
            {
                string pigeonstpc = "/" + "SKINNAME.pc";
                string pigeonstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + pigeonstpc;
                string stinfoph = mwpath + pigeonstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string pigeonpcph = mwpath + pcfile;
                string pigeoninfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/pigeon/pigeon.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/pigeon/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/pigeon/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/pigeon/info_SKINNAME.json");
                StorageFile pigeonjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile pigeonmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile pigeonpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile pigeoninfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder pigeonjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pigeonmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder pigeonpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder pigeoninfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await pigeonjbeamfile.CopyAsync(pigeonjbeampath);
                await pigeonmatfile.CopyAsync(pigeonmatpath);
                await pigeonpcfile.CopyAsync(pigeonpcpath);
                await pigeoninfofile.CopyAsync(pigeoninfopath);
                File.Move(stpcph, pigeonpcph);
                File.Move(stinfoph, pigeoninfoph);

                string pigeonjbpath = namepath + "/" + "pigeon.jbeam";
                string pigeonjb = File.ReadAllText(pigeonjbpath);
                pigeonjb = pigeonjb.Replace("SKINNAME", inttext);
                pigeonjb = pigeonjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(pigeonjbpath, pigeonjb);

                string pigeonmatpathh = namepath + "/" + "materials.json";
                string pigeonmat = File.ReadAllText(pigeonmatpathh);
                pigeonmat = pigeonmat.Replace("SKINNAME", inttext);
                File.WriteAllText(pigeonmatpathh, pigeonmat);

                string pigeonpcpathh = mwpath + pcfile;
                string pigeonpc = File.ReadAllText(pigeonpcpathh);
                pigeonpc = pigeonpc.Replace("SKINNAME", inttext);
                File.WriteAllText(pigeonpcpathh, pigeonpc);

                string pigeoninfopathh = mwpath + infofile;
                string pigeoninfoo = File.ReadAllText(pigeoninfopathh);
                pigeoninfoo = pigeoninfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(pigeoninfopathh, pigeoninfoo);
            }

            if (MainWindow.endtext == "wigeon")
            {
                string wigeonstpc = "/" + "SKINNAME.pc";
                string wigeonstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + wigeonstpc;
                string stinfoph = mwpath + wigeonstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string wigeonpcph = mwpath + pcfile;
                string wigeoninfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/wigeon/wigeon.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/wigeon/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/wigeon/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/wigeon/info_SKINNAME.json");
                StorageFile wigeonjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile wigeonmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile wigeonpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile wigeoninfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder wigeonjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder wigeonmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder wigeonpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder wigeoninfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await wigeonjbeamfile.CopyAsync(wigeonjbeampath);
                await wigeonmatfile.CopyAsync(wigeonmatpath);
                await wigeonpcfile.CopyAsync(wigeonpcpath);
                await wigeoninfofile.CopyAsync(wigeoninfopath);
                File.Move(stpcph, wigeonpcph);
                File.Move(stinfoph, wigeoninfoph);

                string wigeonjbpath = namepath + "/" + "wigeon.jbeam";
                string wigeonjb = File.ReadAllText(wigeonjbpath);
                wigeonjb = wigeonjb.Replace("SKINNAME", inttext);
                wigeonjb = wigeonjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(wigeonjbpath, wigeonjb);

                string wigeonmatpathh = namepath + "/" + "materials.json";
                string wigeonmat = File.ReadAllText(wigeonmatpathh);
                wigeonmat = wigeonmat.Replace("SKINNAME", inttext);
                File.WriteAllText(wigeonmatpathh, wigeonmat);

                string wigeonpcpathh = mwpath + pcfile;
                string wigeonpc = File.ReadAllText(wigeonpcpathh);
                wigeonpc = wigeonpc.Replace("SKINNAME", inttext);
                File.WriteAllText(wigeonpcpathh, wigeonpc);

                string wigeoninfopathh = mwpath + infofile;
                string wigeoninfoo = File.ReadAllText(wigeoninfopathh);
                wigeoninfoo = wigeoninfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(wigeoninfopathh, wigeoninfoo);
            }

            if (MainWindow.endtext == "lansdale")
            {
                string lansdalestpc = "/" + "SKINNAME.pc";
                string lansdalestinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + lansdalestpc;
                string stinfoph = mwpath + lansdalestinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string lansdalepcph = mwpath + pcfile;
                string lansdaleinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/lansdale/lansdale.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/lansdale/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/lansdale/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/lansdale/info_SKINNAME.json");
                StorageFile lansdalejbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile lansdalematfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile lansdalepcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile lansdaleinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder lansdalejbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder lansdalematpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder lansdalepcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder lansdaleinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await lansdalejbeamfile.CopyAsync(lansdalejbeampath);
                await lansdalematfile.CopyAsync(lansdalematpath);
                await lansdalepcfile.CopyAsync(lansdalepcpath);
                await lansdaleinfofile.CopyAsync(lansdaleinfopath);
                File.Move(stpcph, lansdalepcph);
                File.Move(stinfoph, lansdaleinfoph);

                string lansdalejbpath = namepath + "/" + "lansdale.jbeam";
                string lansdalejb = File.ReadAllText(lansdalejbpath);
                lansdalejb = lansdalejb.Replace("SKINNAME", inttext);
                lansdalejb = lansdalejb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(lansdalejbpath, lansdalejb);

                string lansdalematpathh = namepath + "/" + "materials.json";
                string lansdalemat = File.ReadAllText(lansdalematpathh);
                lansdalemat = lansdalemat.Replace("SKINNAME", inttext);
                File.WriteAllText(lansdalematpathh, lansdalemat);

                string lansdalepcpathh = mwpath + pcfile;
                string lansdalepc = File.ReadAllText(lansdalepcpathh);
                lansdalepc = lansdalepc.Replace("SKINNAME", inttext);
                File.WriteAllText(lansdalepcpathh, lansdalepc);

                string lansdaleinfopathh = mwpath + infofile;
                string lansdaleinfoo = File.ReadAllText(lansdaleinfopathh);
                lansdaleinfoo = lansdaleinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(lansdaleinfopathh, lansdaleinfoo);
            }

            if (MainWindow.endtext == "wendover")
            {
                string wendoverstpc = "/" + "SKINNAME.pc";
                string wendoverstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + wendoverstpc;
                string stinfoph = mwpath + wendoverstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string wendoverpcph = mwpath + pcfile;
                string wendoverinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/wendover/wendover.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/wendover/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/wendover/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/wendover/info_SKINNAME.json");
                StorageFile wendoverjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile wendovermatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile wendoverpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile wendoverinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder wendoverjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder wendovermatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder wendoverpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder wendoverinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await wendoverjbeamfile.CopyAsync(wendoverjbeampath);
                await wendovermatfile.CopyAsync(wendovermatpath);
                await wendoverpcfile.CopyAsync(wendoverpcpath);
                await wendoverinfofile.CopyAsync(wendoverinfopath);
                File.Move(stpcph, wendoverpcph);
                File.Move(stinfoph, wendoverinfoph);

                string wendoverjbpath = namepath + "/" + "wendover.jbeam";
                string wendoverjb = File.ReadAllText(wendoverjbpath);
                wendoverjb = wendoverjb.Replace("SKINNAME", inttext);
                wendoverjb = wendoverjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(wendoverjbpath, wendoverjb);

                string wendovermatpathh = namepath + "/" + "materials.json";
                string wendovermat = File.ReadAllText(wendovermatpathh);
                wendovermat = wendovermat.Replace("SKINNAME", inttext);
                File.WriteAllText(wendovermatpathh, wendovermat);

                string wendoverpcpathh = mwpath + pcfile;
                string wendoverpc = File.ReadAllText(wendoverpcpathh);
                wendoverpc = wendoverpc.Replace("SKINNAME", inttext);
                File.WriteAllText(wendoverpcpathh, wendoverpc);

                string wendoverinfopathh = mwpath + infofile;
                string wendoverinfoo = File.ReadAllText(wendoverinfopathh);
                wendoverinfoo = wendoverinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(wendoverinfopathh, wendoverinfoo);
            }

            if (MainWindow.endtext == "racetruck")
            {
                string racetruckstpc = "/" + "SKINNAME.pc";
                string racetruckstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + racetruckstpc;
                string stinfoph = mwpath + racetruckstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string racetruckpcph = mwpath + pcfile;
                string racetruckinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/racetruck/racetruck.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/racetruck/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/racetruck/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/racetruck/info_SKINNAME.json");
                StorageFile racetruckjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile racetruckmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile racetruckpcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile racetruckinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder racetruckjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder racetruckmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder racetruckpcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder racetruckinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await racetruckjbeamfile.CopyAsync(racetruckjbeampath);
                await racetruckmatfile.CopyAsync(racetruckmatpath);
                await racetruckpcfile.CopyAsync(racetruckpcpath);
                await racetruckinfofile.CopyAsync(racetruckinfopath);
                File.Move(stpcph, racetruckpcph);
                File.Move(stinfoph, racetruckinfoph);

                string racetruckjbpath = namepath + "/" + "racetruck.jbeam";
                string racetruckjb = File.ReadAllText(racetruckjbpath);
                racetruckjb = racetruckjb.Replace("SKINNAME", inttext);
                racetruckjb = racetruckjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(racetruckjbpath, racetruckjb);

                string racetruckmatpathh = namepath + "/" + "materials.json";
                string racetruckmat = File.ReadAllText(racetruckmatpathh);
                racetruckmat = racetruckmat.Replace("SKINNAME", inttext);
                File.WriteAllText(racetruckmatpathh, racetruckmat);

                string racetruckpcpathh = mwpath + pcfile;
                string racetruckpc = File.ReadAllText(racetruckpcpathh);
                racetruckpc = racetruckpc.Replace("SKINNAME", inttext);
                File.WriteAllText(racetruckpcpathh, racetruckpc);

                string racetruckinfopathh = mwpath + infofile;
                string racetruckinfoo = File.ReadAllText(racetruckinfopathh);
                racetruckinfoo = racetruckinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(racetruckinfopathh, racetruckinfoo);
            }

            if (MainWindow.endtext == "citybus")
            {
                string citybusstpc = "/" + "SKINNAME.pc";
                string citybusstinfo = "/" + "info_SKINNAME.json";
                string stpcph = mwpath + citybusstpc;
                string stinfoph = mwpath + citybusstinfo;
                string pcfile = "/" + inttext + ".pc";
                string infofile = "/" + "info_" + inttext + ".json";
                string citybuspcph = mwpath + pcfile;
                string citybusinfoph = mwpath + infofile;

                Uri etkjbeamuri = new Uri($"ms-appx:///Assets/text_files/citybus/citybus.jbeam");
                Uri etkmaturi = new Uri($"ms-appx:///Assets/text_files/citybus/materials.json");
                Uri etkpcuri = new Uri($"ms-appx:///Assets/text_files/citybus/SKINNAME.pc");
                Uri etkinfouri = new Uri($"ms-appx:///Assets/text_files/citybus/info_SKINNAME.json");
                StorageFile citybusjbeamfile = await StorageFile.GetFileFromApplicationUriAsync(etkjbeamuri);
                StorageFile citybusmatfile = await StorageFile.GetFileFromApplicationUriAsync(etkmaturi);
                StorageFile citybuspcfile = await StorageFile.GetFileFromApplicationUriAsync(etkpcuri);
                StorageFile citybusinfofile = await StorageFile.GetFileFromApplicationUriAsync(etkinfouri);

                StorageFolder citybusjbeampath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder citybusmatpath = await StorageFolder.GetFolderFromPathAsync(namepath);
                StorageFolder citybuspcpath = await StorageFolder.GetFolderFromPathAsync(mwpath);
                StorageFolder citybusinfopath = await StorageFolder.GetFolderFromPathAsync(mwpath);

                await citybusjbeamfile.CopyAsync(citybusjbeampath);
                await citybusmatfile.CopyAsync(citybusmatpath);
                await citybuspcfile.CopyAsync(citybuspcpath);
                await citybusinfofile.CopyAsync(citybusinfopath);
                File.Move(stpcph, citybuspcph);
                File.Move(stinfoph, citybusinfoph);

                string citybusjbpath = namepath + "/" + "citybus.jbeam";
                string citybusjb = File.ReadAllText(citybusjbpath);
                citybusjb = citybusjb.Replace("SKINNAME", inttext);
                citybusjb = citybusjb.Replace("YOUR SKIN NAME", exttext);
                File.WriteAllText(citybusjbpath, citybusjb);

                string citybusmatpathh = namepath + "/" + "materials.json";
                string citybusmat = File.ReadAllText(citybusmatpathh);
                citybusmat = citybusmat.Replace("SKINNAME", inttext);
                File.WriteAllText(citybusmatpathh, citybusmat);

                string citybuspcpathh = mwpath + pcfile;
                string citybuspc = File.ReadAllText(citybuspcpathh);
                citybuspc = citybuspc.Replace("SKINNAME", inttext);
                File.WriteAllText(citybuspcpathh, citybuspc);

                string citybusinfopathh = mwpath + infofile;
                string citybusinfoo = File.ReadAllText(citybusinfopathh);
                citybusinfoo = citybusinfoo.Replace("SKIN NAME", exttext);
                File.WriteAllText(citybusinfopathh, citybusinfoo);
            }

            ContentFrame.Navigate(typeof(PackingPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            MainWindow.progressBar.Value = 100;
            MainWindow.progressBar.IsIndeterminate = false;
        }

        private void backbutton_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(typeof(uploadingUVPage), null, new SlideNavigationTransitionInfo() { Effect = SlideNavigationTransitionEffect.FromRight });
            MainWindow.progressBar.Value = 50;
        }
    }
}
