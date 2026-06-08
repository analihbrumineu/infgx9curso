/*
               File: MovDoCliente
        Description: Movimentos dos clientes e seus dependentes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/3/2026 10:48:12.61
       Program type: Callable routine
          Main DBMS: sqlserver
*/
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
   public class wmovdocliente : GXWorkpanel
   {
      public wmovdocliente( int hnd ,
                            ModelContext jContext ) : base(hnd, jContext)
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public wmovdocliente( IGxContext context ) : base(-1, null)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public wmovdocliente( IGxContext context ,
                            int hnd ,
                            ModelContext jContext ) : base(hnd, jContext)
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public override String getObjectName( )
      {
         return "MovDoCliente" ;
      }

      public override String getFrmTitle( )
      {
         return "Movimentos dos clientes e seus dependentes." ;
      }

      public override GXMenuBar getMenuBar( )
      {
         return new bmenuprincipal(context, this) ;
      }

      public override int getFrmTop( )
      {
         return 0 ;
      }

      public override int getFrmLeft( )
      {
         return 0 ;
      }

      public override int getFrmWidth( )
      {
         return 1182 ;
      }

      public override int getFrmHeight( )
      {
         return 833 ;
      }

      public override String getHelpId( )
      {
         return "HLP_WMovDoCliente.htm";
      }

      public override int getFrmBackground( )
      {
         return UIFactory.getColor(15) ;
      }

      public override int getFrmForeground( )
      {
         return UIFactory.getColor(6) ;
      }

      public override bool isMainProgram( )
      {
         return IsMain;
      }

      public override bool isModal( )
      {
         return true ;
      }

      protected bool hasDBAccess( )
      {
         return true ;
      }

      public override int getRefreshTimeout( )
      {
         return 0 ;
      }

      public override bool getRefreshTimeoutAlways( )
      {
         return true ;
      }

      public override bool getPaintAfterStart( )
      {
         return true ;
      }

      public override int getBorderStyle( )
      {
         return 2 ;
      }

      public override bool getMaxButton( )
      {
         return true ;
      }

      public override bool getMinButton( )
      {
         return true ;
      }

      public override bool getCtrlBox( )
      {
         return true ;
      }

      public override bool getShowInTaskbar( )
      {
         return true ;
      }

      public override String getFormIcon( )
      {
         return "" ;
      }

      public override bool getAutocenter( )
      {
         return false ;
      }

      public override bool hasStatusBar( )
      {
         return true;
      }

      public void execute( int aP0_PesCodigo ,
                           short aP1_Depende )
      {
         this.AV11PesCod = aP0_PesCodigo;
         this.AV15Depend = aP1_Depende;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load07( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwmovdocliente07 = new subwmovdocliente07 ();
         /* Execute user event: E11V2L2 */
         E11V2L2 ();
      }

      public class MovDoCliente_load07 : GXLoadProducer
      {
         wmovdocliente _sf ;

         public MovDoCliente_load07( wmovdocliente uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer07();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load07();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors07();
         }

      }

      public override void GXRefresh( )
      {
         ControlsToVariables();
         GXRefreshCommand();
      }

      protected void GXRefreshCommand( )
      {
         if ( ! gxIsRefreshing )
         {
            gxIsRefreshing = true ;
            ControlsToVariables();
            standAlone();
            VariablesToControls();
            subGxsf7.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow07( )
      {
         return true;
      }

      public void autoRefresh_flow07( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow07() )) {
            subfile.refresh();
            resetSubfileConditions_flow07() ;
         }
      }

      public bool getSearch_flow07( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow07( )
      {
      }

      public void resetSearchConditions_flow07( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow07( )
      {
         return new subwmovdocliente07 ();
      }

      public bool getSearch_flow07( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow07( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow07( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow07( )
      {
         GXRefreshCommand07 ();
      }

      public class MovDoCliente_flow07 : GXSubfileFlow
      {
         wmovdocliente _sf ;

         public MovDoCliente_flow07( wmovdocliente uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow07();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow07(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow07();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow07();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow07(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow07();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow07(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow07(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow07(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow07();
         }

      }

      protected void GXRefreshCommand07( )
      {
         ControlsToVariables();
         /* End function GeneXus Refresh */
      }

      public void loadToBuffer07( )
      {
         subwmovdocliente07 oAux = subwmovdocliente07 ;
         subwmovdocliente07 = new subwmovdocliente07 ();
         variablesToSubfile07 ();
         subGxsf7.addElement(subwmovdocliente07);
         subwmovdocliente07 = oAux;
      }

      private void E11V2L2( )
      {
         AV16PesCod = 0 ;
         AV17PesNom = "" ;
         AV13TotDev = 0 ;
         AV14TotCan = 0 ;
         /* Load Routine */
         AV16PesCod = AV11PesCod ;
         /* Using cursor W002L2 */
         pr_default.execute(0, new Object[] {AV16PesCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A13PesCodi = W002L2_A13PesCodi[0] ;
            A14PesNome = W002L2_A14PesNome[0] ;
            n14PesNome = W002L2_n14PesNome[0] ;
            AV17PesNom = A14PesNome ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
         subGxsf7.loadCommand();
      }

      protected void closeCursors07( )
      {
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1182 , 833 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavDatinicial = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),91, 78, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 91 , 78 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9DatInic" );
         ((GXEdit) edtavDatinicial.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatinicial.addFocusListener(this);
         edtavDatinicial.getGXComponent().setHelpId("HLP_WMovDoCliente.htm");
         edtavDatfinal = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),208, 78, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 208 , 78 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10DatFin" );
         ((GXEdit) edtavDatfinal.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatfinal.addFocusListener(this);
         edtavDatfinal.getGXComponent().setHelpId("HLP_WMovDoCliente.htm");
         addSubfile ( subGxsf7  = new GXSubfile ( new MovDoCliente_load07(this), new MovDoCliente_flow07(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(GXPanel1, "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV15Depend" ), "Dependente"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 104, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 103 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV16PesCod" ), "Pes Cod Na Grid"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 103 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 358, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 357 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV17PesNom" ), "Pes Nom Na Grid"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 357 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectLong ( new GXEdit(10, "ZZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 108, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 107 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV13TotDev" ), "Devoluções"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 107 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         , new GXColumnDefinition( new GUIObjectLong ( new GXEdit(10, "ZZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 102, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 101 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV14TotCan" ), "Cancelamentos"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 101 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , true , true )
         }, 23 , 18 , GXPanel1 , 65 , 104 , 807 , 442 ,  18 ));
         subGxsf7.addActionListener(this);
         subGxsf7.addFocusListener(this);
         subGxsf7.setSortOnClick(true);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "Movimentações por período", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 26 , 159 , 13 );
         lbllbl3 = UIFactory.getLabel(GXPanel1, "De", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 65 , 82 , 17 , 13 );
         lbllbl5 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 182 , 82 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavDatinicial ,
                   edtavDatfinal ,
                   subGxsf7
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf7, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile07( )
      {
         subwmovdocliente07.setVDepende(AV15Depend);
         subwmovdocliente07.setVPesCodNaGrid(AV16PesCod);
         subwmovdocliente07.setVPesNomNaGrid(AV17PesNom);
         subwmovdocliente07.setVTotDevolucao(AV13TotDev);
         subwmovdocliente07.setVTotCancelamento(AV14TotCan);
      }

      protected void subfileToVariables07( )
      {
         AV15Depend = subwmovdocliente07.getVDepende();
         AV16PesCod = subwmovdocliente07.getVPesCodNaGrid();
         AV17PesNom = subwmovdocliente07.getVPesNomNaGrid();
         AV13TotDev = subwmovdocliente07.getVTotDevolucao();
         AV14TotCan = subwmovdocliente07.getVTotCancelamento();
      }

      public override void VariablesToControls( )
      {
         if (cleanedUp) {
            return  ;
         }
         edtavDatinicial.setValue( AV9DatInic );
         edtavDatfinal.setValue( AV10DatFin );
      }

      public override void ControlsToVariables( )
      {
         if (cleanedUp) {
            return  ;
         }
         AV9DatInic = (DateTime)(edtavDatinicial.getValue()) ;
         edtavDatinicial.setValue(AV9DatInic);
         AV10DatFin = (DateTime)(edtavDatfinal.getValue()) ;
         edtavDatfinal.setValue(AV10DatFin);
      }

      protected void eventNoLevelContext( )
      {
         ControlsToVariables();
      }

      public override void eventLevelContext( )
      {
         ControlsToVariables();
         if ( subGxsf7.inValidElement() )
         {
            subwmovdocliente07 = ( subwmovdocliente07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwmovdocliente07 = new subwmovdocliente07 ();
         }
         subfileToVariables07 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile07 ();
         subGxsf7.refreshLineValue(subwmovdocliente07);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf7.inValidElement() )
         {
            subwmovdocliente07 = ( subwmovdocliente07 ) subGxsf7.getCurrentElement() ;
         }
         else
         {
            subwmovdocliente07 = new subwmovdocliente07 ();
         }
         subfileToVariables07 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf7.isEventSource(eventSource) ) {
            return;
         }
      }

      public override void setCurrentGXCursor( Object eventSource )
      {
         if ( edtavDatinicial.isEventSource(eventSource) ) {
            setGXCursor( edtavDatinicial.getGXCursor() );
            return;
         }
         if ( edtavDatfinal.isEventSource(eventSource) ) {
            setGXCursor( edtavDatfinal.getGXCursor() );
            return;
         }
      }

      public override void gotFocusEventDispatch( Object eventSource )
      {
      }

      public override void focusEventDispatch( Object eventSource )
      {
      }

      public override void updateAttributes( Object eventSource )
      {
         if ( edtavDatinicial.isEventSource(eventSource) ) {
            AV9DatInic = edtavDatinicial.getValue() ;
            return;
         }
         if ( edtavDatfinal.isEventSource(eventSource) ) {
            AV10DatFin = edtavDatfinal.getValue() ;
            return;
         }
      }

      public override void itemEventDispatch( Object eventSource )
      {
      }

      public override void mouseEventDispatch( Object eventSource ,
                                               int modifier )
      {
      }

      public override bool keyEventDispatch( Object eventSource ,
                                             int keyCode )
      {
         if (triggerEventEnter(eventSource, keyCode)) {
            return true ;
         }
         return false;
      }

      public override bool contextItemDispatch( Object eventSource ,
                                                String action )
      {
         return false;
      }

      public override bool menuActionPerformed( String action )
      {
         return false;
      }

      public void refreshArray( String array )
      {
      }

      public void refreshSDT( String name )
      {
      }

      public override void cleanup( )
      {
         if ( ! exitExecuted )
         {
            exitExecuted = true ;
         }
         stopThreads();
         CloseOpenCursors();
         base.cleanup();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         com.genexus.Application.cleanup( base.context , this, remoteHandle);
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         subwmovdocliente07 = new subwmovdocliente07();
         gxIsRefreshing = false ;
         AV16PesCod = 0 ;
         AV17PesNom = "" ;
         AV13TotDev = 0 ;
         AV14TotCan = 0 ;
         scmdbuf = "" ;
         W002L2_A13PesCodi = new int[1] ;
         W002L2_A14PesNome = new String[] {""} ;
         W002L2_n14PesNome = new bool[] {false} ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         n14PesNome = false ;
         AV9DatInic = (DateTime)(DateTime.MinValue) ;
         AV10DatFin = (DateTime)(DateTime.MinValue) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wmovdocliente__default(),
            new Object[][] {
                new Object[] {
               W002L2_A13PesCodi, W002L2_A14PesNome, W002L2_n14PesNome
               }
            }
         );
         reloadDynamicLists(0);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      protected short AV15Depend ;
      protected int AV11PesCod ;
      protected int AV16PesCod ;
      protected int A13PesCodi ;
      protected long AV13TotDev ;
      protected long AV14TotCan ;
      protected String scmdbuf ;
      protected DateTime AV9DatInic ;
      protected DateTime AV10DatFin ;
      protected bool gxIsRefreshing ;
      protected bool n14PesNome ;
      protected String AV17PesNom ;
      protected String A14PesNome ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwmovdocliente07 subwmovdocliente07 ;
      protected IDataReader W002L2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002L2_A13PesCodi ;
      protected String[] W002L2_A14PesNome ;
      protected bool[] W002L2_n14PesNome ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectDatetime edtavDatinicial ;
      protected GUIObjectDatetime edtavDatfinal ;
      protected GXSubfile subGxsf7 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl3 ;
      protected ILabel lbllbl5 ;
   }

   public class wmovdocliente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( ( def == null ) )
       {
          Object[] prmW002L2 ;
          prmW002L2 = new Object[] {
          new Object[] {"@AV16PesCod",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002L2", "SELECT [PesCodigo], [PesNome] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @AV16PesCod ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002L2,1,0,true,true )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
