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
   public class subwconsfilme08 : GXSubfileElement
   {
      private int FilCodigo ;
      private String FilNome ;
      private short FilSituacao ;
      private String FilSituacaoDescription ;
      private DateTime FilData ;
      private String FilDescricao ;
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

      public DateTime getFilData( )
      {
         return FilData ;
      }

      public void setFilData( DateTime value )
      {
         FilData = value;
      }

      public String getFilDescricao( )
      {
         return FilDescricao ;
      }

      public void setFilDescricao( String value )
      {
         FilDescricao = value;
      }

      public override void clear( )
      {
         FilCodigo = 0 ;
         FilNome = "" ;
         FilSituacao = 0 ;
         FilData = DateTime.MinValue ;
         FilDescricao = "" ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  if ( getFilCodigo() > ((subwconsfilme08) element).getFilCodigo() ) return 1;
                  if ( getFilCodigo() < ((subwconsfilme08) element).getFilCodigo() ) return -1;
                  return 0;
               case 1 :
                  return  getFilNome().CompareTo(((subwconsfilme08) element).getFilNome()) ;
               case 2 :
                  if ( getFilSituacao() > ((subwconsfilme08) element).getFilSituacao() ) return 1;
                  if ( getFilSituacao() < ((subwconsfilme08) element).getFilSituacao() ) return -1;
                  return 0;
               case 3 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getFilData()) , GxConvert.AnyDateToJDate(((subwconsfilme08) element).getFilData()) );
               case 4 :
                  return  getFilDescricao().CompareTo(((subwconsfilme08) element).getFilDescricao()) ;
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( getFilCodigo() == 0 ) && ( String.CompareOrdinal(getFilNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getFilSituacao() == 0 ) && ( getFilData() == DateTime.MinValue ) && ( String.CompareOrdinal(getFilDescricao().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) )  ;
      }

      public override void setColumn( GXComponent cell ,
                                      int field )
      {
         switch (field) {
            case 0 :
               cell.setValue( getFilCodigo() );
               break;
            case 1 :
               cell.setValue( getFilNome() );
               break;
            case 2 :
               cell.setValue( getFilSituacao() );
               break;
            case 3 :
               cell.setValue( GxConvert.AnyDateToJDate(getFilData()) );
               break;
            case 4 :
               cell.setValue( getFilDescricao() );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
            case 2 :
               return getFilSituacaoDescription() ;
         }
         return "";
      }

      public bool isFieldChanged( GXComponent cell ,
                                  int field )
      {
         switch (field) {
            case 0 :
               return ( (((GUIObjectInt) cell).getValue() == getFilCodigo()) );
            case 1 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilNome()) == 0) );
            case 2 :
               return ( (((GUIObjectShort) cell).getValue() == getFilSituacao()) );
            case 3 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getFilData()))) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getFilDescricao()) == 0) );
         }
         return false;
      }

      public override void setField( int i ,
                                     GXComponent value )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(value.getIntValue());
                  break;
               case 1 :
                  setFilNome(value.getStringValue());
                  break;
               case 2 :
                  setFilSituacao(value.getShortValue());
                  setFilSituacaoDescription( value.getText());
                  break;
               case 3 :
                  setFilData(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
               case 4 :
                  setFilDescricao(value.getStringValue());
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setFilCodigo(((subwconsfilme08) element).getFilCodigo());
                  return;
               case 1 :
                  setFilNome(((subwconsfilme08) element).getFilNome());
                  return;
               case 2 :
                  setFilSituacao(((subwconsfilme08) element).getFilSituacao());
                  setFilSituacaoDescription(((subwconsfilme08) element).getFilSituacaoDescription());
                  return;
               case 3 :
                  setFilData(((subwconsfilme08) element).getFilData());
                  return;
               case 4 :
                  setFilDescricao(((subwconsfilme08) element).getFilDescricao());
                  return;
         }
      }

   }

}
