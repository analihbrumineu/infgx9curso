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
using GeneXus.XML;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class subwpelocacao11 : GXSubfileElement
   {
      private String VMarcado ;
      private String VVisualizar ;
      private String VEditar ;
      private int LocCodigo ;
      private DateTime LocDatLocacao ;
      private int LocCliPesCodigo ;
      private String LocCliPesNome ;
      private short LocSituacao ;
      private String LocSituacaoDescription ;
      public String getVMarcado( )
      {
         return VMarcado ;
      }

      public void setVMarcado( String value )
      {
         VMarcado = value;
      }

      public String getVVisualizar( )
      {
         return VVisualizar ;
      }

      public void setVVisualizar( String value )
      {
         VVisualizar = value;
      }

      public String getVEditar( )
      {
         return VEditar ;
      }

      public void setVEditar( String value )
      {
         VEditar = value;
      }

      public int getLocCodigo( )
      {
         return LocCodigo ;
      }

      public void setLocCodigo( int value )
      {
         LocCodigo = value;
      }

      public DateTime getLocDatLocacao( )
      {
         return LocDatLocacao ;
      }

      public void setLocDatLocacao( DateTime value )
      {
         LocDatLocacao = value;
      }

      public int getLocCliPesCodigo( )
      {
         return LocCliPesCodigo ;
      }

      public void setLocCliPesCodigo( int value )
      {
         LocCliPesCodigo = value;
      }

      public String getLocCliPesNome( )
      {
         return LocCliPesNome ;
      }

      public void setLocCliPesNome( String value )
      {
         LocCliPesNome = value;
      }

      public short getLocSituacao( )
      {
         return LocSituacao ;
      }

      public void setLocSituacao( short value )
      {
         LocSituacao = value;
      }

      public String getLocSituacaoDescription( )
      {
         return LocSituacaoDescription ;
      }

      public void setLocSituacaoDescription( String value )
      {
         LocSituacaoDescription = value;
      }

      public override void clear( )
      {
         VMarcado = "" ;
         VVisualizar = "" ;
         VEditar = "" ;
         LocCodigo = 0 ;
         LocDatLocacao = DateTime.MinValue ;
         LocCliPesCodigo = 0 ;
         LocCliPesNome = "" ;
         LocSituacao = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVMarcado().CompareTo(((subwpelocacao11) element).getVMarcado()) ;
               case 1 :
                  return  getVVisualizar().CompareTo(((subwpelocacao11) element).getVVisualizar()) ;
               case 2 :
                  return  getVEditar().CompareTo(((subwpelocacao11) element).getVEditar()) ;
               case 3 :
                  if ( getLocCodigo() > ((subwpelocacao11) element).getLocCodigo() ) return 1;
                  if ( getLocCodigo() < ((subwpelocacao11) element).getLocCodigo() ) return -1;
                  return 0;
               case 4 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getLocDatLocacao()) , GxConvert.AnyDateToJDate(((subwpelocacao11) element).getLocDatLocacao()) );
               case 5 :
                  if ( getLocCliPesCodigo() > ((subwpelocacao11) element).getLocCliPesCodigo() ) return 1;
                  if ( getLocCliPesCodigo() < ((subwpelocacao11) element).getLocCliPesCodigo() ) return -1;
                  return 0;
               case 6 :
                  return  getLocCliPesNome().CompareTo(((subwpelocacao11) element).getLocCliPesNome()) ;
               case 7 :
                  if ( getLocSituacao() > ((subwpelocacao11) element).getLocSituacao() ) return 1;
                  if ( getLocSituacao() < ((subwpelocacao11) element).getLocSituacao() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVMarcado().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getLocCodigo() == 0 ) && ( getLocDatLocacao() == DateTime.MinValue ) && ( getLocCliPesCodigo() == 0 ) && ( String.CompareOrdinal(getLocCliPesNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getLocSituacao() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVMarcado() );
               break;
            case 1 :
               cell.setValue( getVVisualizar() );
               break;
            case 2 :
               cell.setValue( getVEditar() );
               break;
            case 3 :
               cell.setValue( getLocCodigo() );
               break;
            case 4 :
               cell.setValue( GxConvert.AnyDateToJDate(getLocDatLocacao()) );
               break;
            case 5 :
               cell.setValue( getLocCliPesCodigo() );
               break;
            case 6 :
               cell.setValue( getLocCliPesNome() );
               break;
            case 7 :
               cell.setValue( getLocSituacao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 7 :
               return getLocSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVMarcado()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVVisualizar()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 3 :
               return ( (((GUIObjectInt) cell).getValue() == getLocCodigo()) );
            case 4 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getLocDatLocacao()))) );
            case 5 :
               return ( (((GUIObjectInt) cell).getValue() == getLocCliPesCodigo()) );
            case 6 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getLocCliPesNome()) == 0) );
            case 7 :
               return ( (((GUIObjectShort) cell).getValue() == getLocSituacao()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setVMarcado(value.getStringValue());
                  break;
               case 1 :
                  break;
               case 2 :
                  break;
               case 3 :
                  setLocCodigo(value.getIntValue());
                  break;
               case 4 :
                  setLocDatLocacao(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 5 :
                  setLocCliPesCodigo(value.getIntValue());
                  break;
               case 6 :
                  setLocCliPesNome(value.getStringValue());
                  break;
               case 7 :
                  setLocSituacao(value.getShortValue());
                  setLocSituacaoDescription( value.getText());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVMarcado(((subwpelocacao11) element).getVMarcado());
                  return;
               case 1 :
                  setVVisualizar(((subwpelocacao11) element).getVVisualizar());
                  return;
               case 2 :
                  setVEditar(((subwpelocacao11) element).getVEditar());
                  return;
               case 3 :
                  setLocCodigo(((subwpelocacao11) element).getLocCodigo());
                  return;
               case 4 :
                  setLocDatLocacao(((subwpelocacao11) element).getLocDatLocacao());
                  return;
               case 5 :
                  setLocCliPesCodigo(((subwpelocacao11) element).getLocCliPesCodigo());
                  return;
               case 6 :
                  setLocCliPesNome(((subwpelocacao11) element).getLocCliPesNome());
                  return;
               case 7 :
                  setLocSituacao(((subwpelocacao11) element).getLocSituacao());
                  setLocSituacaoDescription(((subwpelocacao11) element).getLocSituacaoDescription());
                  return;
         }
      }

   }

}
