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
   public class subwpefilme02 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int FilCodigo ;
      private String FilNome ;
      private DateTime FilData ;
      private String CatNome ;
      private short FilSituacao ;
      private String FilSituacaoDescription ;
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

      public String getVExcluir( )
      {
         return VExcluir ;
      }

      public void setVExcluir( String value )
      {
         VExcluir = value;
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
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
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
                  return  getVVisualizar().CompareTo(((subwpefilme02) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpefilme02) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpefilme02) element).getVExcluir()) ;
               case 3 :
                  if ( getFilCodigo() > ((subwpefilme02) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwpefilme02) element).getFilCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getFilNome().CompareTo(((subwpefilme02) element).getFilNome()) ;
               case 5 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwpefilme02) element).getFilData()) );
               case 6 :
                  return  getCatNome().CompareTo(((subwpefilme02) element).getCatNome()) ;
               case 7 :
                  if ( getFilSituacao() > ((subwpefilme02) element).getFilSituacao() ) return 1;
                  if ( getFilSituacao() < ((subwpefilme02) element).getFilSituacao() ) return -1;
                  return 0;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilData() == DateTime.MinValue ) && ( String.CompareOrdinal(getCatNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilSituacao() == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getVVisualizar() );
               break;
            case 1 :
               cell.setValue( getVEditar() );
               break;
            case 2 :
               cell.setValue( getVExcluir() );
               break;
            case 3 :
               cell.setValue( getFilCodigo() );
               break;
            case 4 :
               cell.setValue( getFilNome() );
               break;
            case 5 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
            case 6 :
               cell.setValue( getCatNome() );
               break;
            case 7 :
               cell.setValue( getFilSituacao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 7 :
               return getFilSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVVisualizar()) == 0) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVEditar()) == 0) );
            case 2 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getVExcluir()) == 0) );
            case 3 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
            case 5 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
            case 6 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getCatNome()) == 0) );
            case 7 :
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
                  break;
               case 3 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 4 :
                  setFilNome(value.getStringValue());
                  break;
               case 5 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 6 :
                  setCatNome(value.getStringValue());
                  break;
               case 7 :
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
                  setVVisualizar(((subwpefilme02) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpefilme02) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpefilme02) element).getVExcluir());
                  return;
               case 3 :
                  setFilCodigo(((subwpefilme02) element).getFilCodigo());
                  return;
               case 4 :
                  setFilNome(((subwpefilme02) element).getFilNome());
                  return;
               case 5 :
                  setFilData(((subwpefilme02) element).getFilData());
                  return;
               case 6 :
                  setCatNome(((subwpefilme02) element).getCatNome());
                  return;
               case 7 :
                  setFilSituacao(((subwpefilme02) element).getFilSituacao());
                  setFilSituacaoDescription(((subwpefilme02) element).getFilSituacaoDescription());
                  return;
         }
      }

   }

}
