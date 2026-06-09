using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using com.genexus;
using com.genexus.ui;
using com.genexus.uifactory;
using GeneXus.Windows;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus.distributed;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting.Channels.Http;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.Printer;
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem : GxUserType
   {
      public SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError ;
         GXSoapError = 1 ;
         sTagName = oReader.Name ;
         GXSoapError = oReader.Read() ;
         nOutParmCount = 0 ;
         while ( ( ( String.CompareOrdinal(oReader.Name.TrimEnd(' '), sTagName.TrimEnd(' ') ) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
         {
            readOk = 0 ;
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "LocMidMidCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "MidTipo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo = (short)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "MidTipRelTotal".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal = (long)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            GXSoapError = oReader.Read() ;
            nOutParmCount = (short)(nOutParmCount+1) ;
            if ( ( readOk == 0 ) )
            {
               context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
               GXSoapError = (short)(nOutParmCount*-1) ;
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         short GXSoapError ;
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sName).TrimEnd(' ') )==0)) )
         {
            sName = "SDTMidTipRelatorio.SDTMidTipDevRelatorioItem" ;
         }
         if ( ! ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sNameSpace).TrimEnd(' ') )==0)) && ( String.CompareOrdinal(sNameSpace.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) != 0 ) )
         {
            oWriter.WriteStartElement(sName+"ns:"+sName);
            oWriter.WriteAttribute("xmlns:"+sName+"ns", sNameSpace);
         }
         else
         {
            oWriter.WriteStartElement(sName);
         }
         if ( ((String.CompareOrdinal("".TrimEnd(' '), StringUtil.RTrim( sNameSpace).TrimEnd(' ') )==0)) || ( String.CompareOrdinal(sNameSpace.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) != 0 ) )
         {
            oWriter.WriteAttribute("xmlns", "AgoraVaiCurso");
         }
         oWriter.WriteElement("LocMidMidCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo), 9, 0)));
         oWriter.WriteElement("MidTipo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo), 1, 0)));
         oWriter.WriteElement("MidTipRelTotal", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Locmidmidcodigo
      {
         get {
            return gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo ;
         }

         set {
            gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo_SetNull( )
      {
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo = 0 ;
         return  ;
      }

      public short gxTpr_Midtipo
      {
         get {
            return gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo ;
         }

         set {
            gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo = (short)(value) ;
         }

      }

      public void gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo_SetNull( )
      {
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo = 0 ;
         return  ;
      }

      public long gxTpr_Midtipreltotal
      {
         get {
            return gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal ;
         }

         set {
            gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal_SetNull( )
      {
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo = 0 ;
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo = 0 ;
         gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipo ;
      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Locmidmidcodigo ;
      private long gxTv_SdtSDTMidTipRelatorio_SDTMidTipDevRelatorioItem_Midtipreltotal ;
      private String sTagName ;
      private String GXt_char1 ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
