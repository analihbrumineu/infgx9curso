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
   public class SdtSDTCliRelatorio_SDTCliDevolucaoItem : GxUserType
   {
      public SdtSDTCliRelatorio_SDTCliDevolucaoItem( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtSDTCliRelatorio_SDTCliDevolucaoItem( IGxContext context )
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
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliRelLocCliPesCodigo".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo = (int)(NumberUtil.Val( oReader.Value, true)) ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliRelLocCliPesNome".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome = oReader.Value ;
               if ( ( GXSoapError > 0 ) )
               {
                  readOk = 1 ;
               }
            }
            if ( ( String.CompareOrdinal(oReader.LocalName.TrimEnd(' '), "CliRelTotal".TrimEnd(' ') ) == 0 ) && ( ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "AgoraVaiCurso".TrimEnd(' ') ) == 0 ) || ( String.CompareOrdinal(oReader.NamespaceURI.TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) ) )
            {
               gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal = (long)(NumberUtil.Val( oReader.Value, true)) ;
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
            sName = "SDTCliRelatorio.SDTCliDevolucaoItem" ;
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
         oWriter.WriteElement("CliRelLocCliPesCodigo", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo), 9, 0)));
         oWriter.WriteElement("CliRelLocCliPesNome", StringUtil.RTrim( gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome));
         oWriter.WriteElement("CliRelTotal", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal), 10, 0)));
         oWriter.WriteEndElement();
         return  ;
      }

      public int gxTpr_Clirellocclipescodigo
      {
         get {
            return gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo ;
         }

         set {
            gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo = (int)(value) ;
         }

      }

      public void gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo_SetNull( )
      {
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo = 0 ;
         return  ;
      }

      public String gxTpr_Clirellocclipesnome
      {
         get {
            return gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome ;
         }

         set {
            gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome = (String)(value) ;
         }

      }

      public void gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome_SetNull( )
      {
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome = "" ;
         return  ;
      }

      public long gxTpr_Clireltotal
      {
         get {
            return gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal ;
         }

         set {
            gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal = (long)(value) ;
         }

      }

      public void gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal_SetNull( )
      {
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal = 0 ;
         return  ;
      }

      public void initialize( )
      {
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo = 0 ;
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome = "" ;
         gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal = 0 ;
         sTagName = "" ;
         nOutParmCount = 0 ;
         readOk = 0 ;
         GXt_char1 = "" ;
         return  ;
      }

      private short nOutParmCount ;
      private short readOk ;
      private int gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipescodigo ;
      private long gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clireltotal ;
      private String sTagName ;
      private String GXt_char1 ;
      private String gxTv_SdtSDTCliRelatorio_SDTCliDevolucaoItem_Clirellocclipesnome ;
      private Assembly constructorCallingAssembly ;
      private IGxContext context ;
      private bool IsMain ;
   }

}
