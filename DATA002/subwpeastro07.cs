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
   public class subwpeastro07 : GXSubfileElement
   {
      private String VVisualizar ;
      private String VEditar ;
      private String VExcluir ;
      private int AstCodigo ;
      private String AstNome ;
      private DateTime AstDatFalecimento ;
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

      public int getAstCodigo( )
      {
         return AstCodigo ;
      }

      public void setAstCodigo( int value )
      {
         AstCodigo = value;
      }

      public String getAstNome( )
      {
         return AstNome ;
      }

      public void setAstNome( String value )
      {
         AstNome = value;
      }

      public DateTime getAstDatFalecimento( )
      {
         return AstDatFalecimento ;
      }

      public void setAstDatFalecimento( DateTime value )
      {
         AstDatFalecimento = value;
      }

      public override void clear( )
      {
         VVisualizar = "" ;
         VEditar = "" ;
         VExcluir = "" ;
         AstCodigo = 0 ;
         AstNome = "" ;
         AstDatFalecimento = DateTime.MinValue ;
      }

      public override int compareTo( GXSubfileElement element ,
                                     int column )
      {
         switch (column)
         {
               case 0 :
                  return  getVVisualizar().CompareTo(((subwpeastro07) element).getVVisualizar()) ;
               case 1 :
                  return  getVEditar().CompareTo(((subwpeastro07) element).getVEditar()) ;
               case 2 :
                  return  getVExcluir().CompareTo(((subwpeastro07) element).getVExcluir()) ;
               case 3 :
                  if ( getAstCodigo() > ((subwpeastro07) element).getAstCodigo() ) return 1;
                  if ( getAstCodigo() < ((subwpeastro07) element).getAstCodigo() ) return -1;
                  return 0;
               case 4 :
                  return  getAstNome().CompareTo(((subwpeastro07) element).getAstNome()) ;
               case 5 :
                  return GXutil.datecmp( GxConvert.AnyDateToJDate(getAstDatFalecimento()) , GxConvert.AnyDateToJDate(((subwpeastro07) element).getAstDatFalecimento()) );
         }
         return 0;
      }

      public override bool isEmpty( )
      {
         return ( ( String.CompareOrdinal(getVVisualizar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVEditar().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( String.CompareOrdinal(getVExcluir().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getAstCodigo() == 0 ) && ( String.CompareOrdinal(getAstNome().TrimEnd(' '), "".TrimEnd(' ') ) == 0 ) && ( getAstDatFalecimento() == DateTime.MinValue ) )  ;
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
               cell.setValue( getAstCodigo() );
               break;
            case 4 :
               cell.setValue( getAstNome() );
               break;
            case 5 :
               cell.setValue( GxConvert.AnyDateToJDate(getAstDatFalecimento()) );
               break;
         }
      }

      public override String getColumn( int field )
      {
         switch (field) {
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
               return ( (((GUIObjectInt) cell).getValue() == getAstCodigo()) );
            case 4 :
               return ( ( GXutil.strcmp(((GUIObjectString) cell).getValue(),getAstNome()) == 0) );
            case 5 :
               return ( (((GUIObjectDatetime) cell).getValue().Equals(GxConvert.AnyDateToJDate(getAstDatFalecimento()))) );
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
                  setAstCodigo(value.getIntValue());
                  break;
               case 4 :
                  setAstNome(value.getStringValue());
                  break;
               case 5 :
                  setAstDatFalecimento(GxConvert.AnyDateToDateTime(value.getDateValue()));
                  break;
         }
      }

      public override void setField( int i ,
                                     GXSubfileElement element )
      {
         switch (i)
         {
               case 0 :
                  setVVisualizar(((subwpeastro07) element).getVVisualizar());
                  return;
               case 1 :
                  setVEditar(((subwpeastro07) element).getVEditar());
                  return;
               case 2 :
                  setVExcluir(((subwpeastro07) element).getVExcluir());
                  return;
               case 3 :
                  setAstCodigo(((subwpeastro07) element).getAstCodigo());
                  return;
               case 4 :
                  setAstNome(((subwpeastro07) element).getAstNome());
                  return;
               case 5 :
                  setAstDatFalecimento(((subwpeastro07) element).getAstDatFalecimento());
                  return;
         }
      }

   }

}
