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
   public class SdtSDTCatRelatorio_SDTCatDevolucaoItem : GxUserType
   {
      public SdtSDTCatRelatorio_SDTCatDevolucaoItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTCatRelatorio_SDTCatDevolucaoItem( IGxContext context )
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
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatRelLocMidCatCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatRelCatNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatRelTotal".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal = (long)(NumberUtil.Val( oReader.Value, true)) ;
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
            sName = "SDTCatRelatorio.SDTCatDevolucaoItem" ;
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
         oWriter.WriteElement("CatRelLocMidCatCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo), 9, 0)));
         oWriter.WriteElement("CatRelCatNome", StringUtil.RTrim( gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome));
         oWriter.WriteElement("CatRelTotal", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Catrellocmidcatcodigo
      {
         get {
            return gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo ;
         }

         set {
            gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo_SetNull( )
      {
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo = 0 ;
         return  ;
      }

      public String gxTpr_Catrelcatnome
      {
         get {
            return gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome ;
         }

         set {
            gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome_SetNull( )
      {
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome = "" ;
         return  ;
      }

      public long gxTpr_Catreltotal
      {
         get {
            return gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal ;
         }

         set {
            gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal_SetNull( )
      {
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo = 0 ;
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome = "" ;
         gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrellocmidcatcodigo ;
      private long gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catreltotal ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTCatRelatorio_SDTCatDevolucaoItem_Catrelcatnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
