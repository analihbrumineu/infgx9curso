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
   public class SdtSDTCatDevolucao_SDTCatDevolucaoItem : GxUserType
   {
      public SdtSDTCatDevolucao_SDTCatDevolucaoItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTCatDevolucao_SDTCatDevolucaoItem( IGxContext context )
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
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatDevLocMidCatCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatDevCatNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CatDevTotDevolucao".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao = (long)(NumberUtil.Val( oReader.Value, true)) ;
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
            sName = "SDTCatDevolucao.SDTCatDevolucaoItem" ;
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
         oWriter.WriteElement("CatDevLocMidCatCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo), 9, 0)));
         oWriter.WriteElement("CatDevCatNome", StringUtil.RTrim( gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome));
         oWriter.WriteElement("CatDevTotDevolucao", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Catdevlocmidcatcodigo
      {
         get {
            return gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo ;
         }

         set {
            gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo_SetNull( )
      {
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo = 0 ;
         return  ;
      }

      public String gxTpr_Catdevcatnome
      {
         get {
            return gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome ;
         }

         set {
            gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome_SetNull( )
      {
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome = "" ;
         return  ;
      }

      public long gxTpr_Catdevtotdevolucao
      {
         get {
            return gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao ;
         }

         set {
            gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao_SetNull( )
      {
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo = 0 ;
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome = "" ;
         gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevlocmidcatcodigo ;
      private long gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevtotdevolucao ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTCatDevolucao_SDTCatDevolucaoItem_Catdevcatnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
