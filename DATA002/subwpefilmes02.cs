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
   public class subwpefilmes02 : GXSubfileElement
   {
      private String VExcluir ;
      private String VEditar ;
      private int FilCodigo ;
      private String FilNome ;
      private DateTime FilData ;
      private String CatNome ;
      private short FilSituacao ;
      private String FilSituacaoDescription ;
      public String getVExcluir( )
      {
         return VExcluir ;
      }

      public void setVExcluir( String value )
      {
         VExcluir = value;
      }

      public String getVEditar( )
      {
         return VEditar ;
      }

      public void setVEditar( String value )
      {
         VEditar = value;
      }

      public int getFilCodigo( )
      {
         return FilCodigo ;
      }

      public void setFilCodigo( int value )
      {
         FilCodigo = value;
      }

      public String getFilNome( )
      {
         return FilNome ;
      }

      public void setFilNome( String value )
      {
         FilNome = value;
      }

      public DateTime getFilData( )
      {
         return FilData ;
      }

      public void setFilData( DateTime value )
      {
         FilData = value;
      }

      public String getCatNome( )
      {
         return CatNome ;
      }

      public void setCatNome( String value )
      {
         CatNome = value;
      }

      public short getFilSituacao( )
      {
         return FilSituacao ;
      }

      public void setFilSituacao( short value )
      {
         FilSituacao = value;
      }

      public String getFilSituacaoDescription( )
      {
         return FilSituacaoDescription ;
      }

      public void setFilSituacaoDescription( String value )
      {
         FilSituacaoDescription = value;
      }

      public override void clear( )
      {
         VExcluir = "" ;
         VEditar = "" ;
         FilCodigo = 0 ;
         FilNome = "" ;
         FilData = DateTime.MinValue ;
         CatNome = "" ;
         FilSituacao = 0 ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVExcluir().CompareTo(((subwpefilmes02) element).getVExcluir()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpefilmes02) element).getVEditar()) ;
               case 2 :
                  if ( getFilCodigo() > ((subwpefilmes02) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwpefilmes02) element).getFilCodigo() ) return -1;
                  return 0;
               case 3 :
                  return  getFilNome().CompareTo(((subwpefilmes02) element).getFilNome()) ;
               case 4 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwpefilmes02) element).getFilData()) );
               case 5 :
                  return  getCatNome().CompareTo(((subwpefilmes02) element).getCatNome()) ;
               case 6 :
                  if ( getFilSituacao() > ((subwpefilmes02) element).getFilSituacao() ) return 1;
                  if ( getFilSituacao() < ((subwpefilmes02) element).getFilSituacao() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilData() == DateTime.MinValue ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilSituacao() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVExcluir() );
               break;
            case 1 :
               cell.setValue( getVEditar() );
               break;
            case 2 :
               cell.setValue( getFilCodigo() );
               break;
            case 3 :
               cell.setValue( getFilNome() );
               break;
            case 4 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
            case 5 :
               cell.setValue( getCatNome() );
               break;
            case 6 :
               cell.setValue( getFilSituacao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 6 :
               return getFilSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 2 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 3 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
            case 4 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
            case 5 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCatNome()) == 0) );
            case 6 :
               return ( (((GUIObjectShort) cell).getValue() == getFilSituacao()) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  break;
               case 1 :
                  break;
               case 2 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 3 :
                  setFilNome(value.getStringValue());
                  break;
               case 4 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 5 :
                  setCatNome(value.getStringValue());
                  break;
               case 6 :
                  setFilSituacao(value.getShortValue());
                  setFilSituacaoDescription( value.getText());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVExcluir(((subwpefilmes02) element).getVExcluir());
                  return;
               case 1 :
                  setVEditar(((subwpefilmes02) element).getVEditar());
                  return;
               case 2 :
                  setFilCodigo(((subwpefilmes02) element).getFilCodigo());
                  return;
               case 3 :
                  setFilNome(((subwpefilmes02) element).getFilNome());
                  return;
               case 4 :
                  setFilData(((subwpefilmes02) element).getFilData());
                  return;
               case 5 :
                  setCatNome(((subwpefilmes02) element).getCatNome());
                  return;
               case 6 :
                  setFilSituacao(((subwpefilmes02) element).getFilSituacao());
                  setFilSituacaoDescription(((subwpefilmes02) element).getFilSituacaoDescription());
                  return;
         }
      }

   }

}
