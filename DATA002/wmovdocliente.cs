/*
               File: MovDoCliente
        Description: Movimentos dos clientes e seus dependentes.
             Author: GeneXus C# Generator version 9_0_7-910
       Generated on: 6/9/2026 11:37:37.99
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
         return "Movimentação do cliente" ;
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
         return 1027 ;
      }

      public override int getFrmHeight( )
      {
         return 806 ;
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

      public void execute( int aP0_PesCodigo )
      {
         this.AV11PesCod = aP0_PesCodigo;
         executePrivate();
      }

      void executePrivate( )
      {
         start();
      }

      public override void standAlone( )
      {
      }

      public void runLoad_load06( )
      {
         if ( exitExecuted )
         {
            return  ;
         }
         subwmovdocliente06 = new subwmovdocliente06 ();
         /* Execute user event: E11V2L2 */
         E11V2L2 ();
      }

      public class MovDoCliente_load06 : GXLoadProducer
      {
         wmovdocliente _sf ;

         public MovDoCliente_load06( wmovdocliente uType ) : base()
         {
            _sf = uType;
         }
         public override void loadToBuffer( )
         {
            _sf.loadToBuffer06();
         }

         public override void runLoad( )
         {
            if(!UIFactory.isDisposed( _sf.getIPanel() )) {
               _sf.runLoad_load06();
            }
         }

         public override void closeCursors( )
         {
            _sf.closeCursors06();
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
            subGxsf6.refresh();
            gxIsRefreshing = false ;
         }
      }

      public override void refreshEvent( )
      {
      }

      public bool isLoadAtStartup_flow06( )
      {
         return true;
      }

      public void autoRefresh_flow06( GXSubfile subfile ,
                                      bool loadedFirstTime )
      {
         if (( false ) || (!loadedFirstTime && ! isLoadAtStartup_flow06() )) {
            subfile.refresh();
            resetSubfileConditions_flow06() ;
         }
      }

      public bool getSearch_flow06( )
      {
         return false ;
      }

      public void resetSubfileConditions_flow06( )
      {
      }

      public void resetSearchConditions_flow06( bool defaults )
      {
      }

      public GXSubfileElement getNewSubfileElement_flow06( )
      {
         return new subwmovdocliente06 ();
      }

      public bool getSearch_flow06( GXSubfileElement subfileElement )
      {
         return true;
      }

      public void setConditionalColor_flow06( GUIObject comp ,
                                              GXSubfileElement element )
      {

      }

      public bool getNoaccept_flow06( int col ,
                                      GXSubfileElement element ,
                                      bool enabled )
      {
         return !enabled;
      }

      public void refresh_flow06( )
      {
         GXRefreshCommand06 ();
      }

      public class MovDoCliente_flow06 : GXSubfileFlow
      {
         wmovdocliente _sf ;

         public MovDoCliente_flow06( wmovdocliente uType ) : base()
         {
            _sf = uType;
         }
         public bool isLoadAtStartup( )
         {
            return _sf.isLoadAtStartup_flow06();
         }

         public void autoRefresh( GXSubfile subfile ,
                                  bool loadedFirstTime )
         {
            _sf.autoRefresh_flow06(subfile, loadedFirstTime);
         }

         public bool getSearch( )
         {
            return _sf.getSearch_flow06();
         }

         public void resetSubfileConditions( )
         {
            _sf.resetSubfileConditions_flow06();
         }

         public void resetSearchConditions( bool defaults )
         {
            _sf.resetSearchConditions_flow06(defaults);
         }

         public GXSubfileElement getNewSubfileElement( )
         {
            return _sf.getNewSubfileElement_flow06();
         }

         public void refreshScreen( )
         {
            _sf.VariablesToControls();
         }

         public bool getSearch( GXSubfileElement subfileElement )
         {
            return _sf.getSearch_flow06(subfileElement);
         }

         public void setConditionalColor( GUIObject comp ,
                                          GXSubfileElement element )
         {
            _sf.setConditionalColor_flow06(comp, element);
         }

         public bool getNoaccept( int col ,
                                  GXSubfileElement element ,
                                  bool enabled )
         {
            return _sf.getNoaccept_flow06(col, element, enabled);
         }

         public void refresh( )
         {
            _sf.refresh_flow06();
         }

      }

      protected void GXRefreshCommand06( )
      {
         ControlsToVariables();
         /* Execute user event: E12V2L2 */
         E12V2L2 ();
         /* End function GeneXus Refresh */
      }

      public override void GXStart( )
      {
         /* Execute user event: E13V2L2 */
         E13V2L2 ();
         if ( returnInSub )
         {
            if (canCleanup()) {
               returnInSub = true;
               this.cleanup();
            }
            if (true) return;
         }
      }

      protected void E13V2L2( )
      {
         eventNoLevelContext();
         /* Start Routine */
         AV9DatInic = Gx_date ;
         edtavDatinicial.setValue(AV9DatInic);
         AV10DatFin = Gx_date ;
         edtavDatfinal.setValue(AV10DatFin);
      }

      protected void E12V2L2( )
      {
         /* Refresh Routine */
         if ( ( AV10DatFin < AV9DatInic ) )
         {
            GXutil.msg( me(), "O final do período não pode ocorrer antes do início." );
         }
         if ( ( AV10DatFin > Gx_date ) )
         {
            GXutil.msg( me(), "Não é possível consultar locações futuras." );
         }
      }

      public void loadToBuffer06( )
      {
         subwmovdocliente06 oAux = subwmovdocliente06 ;
         subwmovdocliente06 = new subwmovdocliente06 ();
         variablesToSubfile06 ();
         subGxsf6.addElement(subwmovdocliente06);
         subwmovdocliente06 = oAux;
      }

      private void E11V2L2( )
      {
         /* Load Routine */
         AV16PesCod = AV11PesCod ;
         AV15Depend = 0 ;
         /* Using cursor W002L2 */
         pr_default.execute(0, new Object[] {AV16PesCod});
         while ( (pr_default.getStatus(0) != 101) )
         {
            A13PesCodi = W002L2_A13PesCodi[0] ;
            A14PesNome = W002L2_A14PesNome[0] ;
            n14PesNome = W002L2_n14PesNome[0] ;
            AV17PesNom = A14PesNome ;
            AV13TotDev = 0 ;
            AV14TotCan = 0 ;
            /* Using cursor W002L3 */
            pr_default.execute(1, new Object[] {A13PesCodi});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A91LocCliP = W002L3_A91LocCliP[0] ;
               n91LocCliP = W002L3_n91LocCliP[0] ;
               A88LocDatL = W002L3_A88LocDatL[0] ;
               n88LocDatL = W002L3_n88LocDatL[0] ;
               A89LocDatD = W002L3_A89LocDatD[0] ;
               n89LocDatD = W002L3_n89LocDatD[0] ;
               A90LocDatC = W002L3_A90LocDatC[0] ;
               n90LocDatC = W002L3_n90LocDatC[0] ;
               if ( ( A89LocDatD >= AV9DatInic ) && ( A89LocDatD <= AV10DatFin ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
               {
                  AV13TotDev = (long)(AV13TotDev+1) ;
               }
               if ( ( A90LocDatC >= AV9DatInic ) && ( A90LocDatC <= AV10DatFin ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
               {
                  AV14TotCan = (long)(AV14TotCan+1) ;
               }
               pr_default.readNext(1);
            }
            pr_default.close(1);
            subGxsf6.loadCommand();
            /* Using cursor W002L4 */
            pr_default.execute(2, new Object[] {A13PesCodi});
            while ( (pr_default.getStatus(2) != 101) )
            {
               A46PesDepC = W002L4_A46PesDepC[0] ;
               A47PesDepN = W002L4_A47PesDepN[0] ;
               n47PesDepN = W002L4_n47PesDepN[0] ;
               A47PesDepN = W002L4_A47PesDepN[0] ;
               n47PesDepN = W002L4_n47PesDepN[0] ;
               AV16PesCod = A46PesDepC ;
               AV17PesNom = A47PesDepN ;
               AV15Depend = 1 ;
               AV13TotDev = 0 ;
               AV14TotCan = 0 ;
               /* Using cursor W002L5 */
               pr_default.execute(3, new Object[] {A46PesDepC});
               while ( (pr_default.getStatus(3) != 101) )
               {
                  A91LocCliP = W002L5_A91LocCliP[0] ;
                  n91LocCliP = W002L5_n91LocCliP[0] ;
                  A88LocDatL = W002L5_A88LocDatL[0] ;
                  n88LocDatL = W002L5_n88LocDatL[0] ;
                  A89LocDatD = W002L5_A89LocDatD[0] ;
                  n89LocDatD = W002L5_n89LocDatD[0] ;
                  A90LocDatC = W002L5_A90LocDatC[0] ;
                  n90LocDatC = W002L5_n90LocDatC[0] ;
                  if ( ( A89LocDatD >= AV9DatInic ) && ( A89LocDatD <= AV10DatFin ) && ( A89LocDatD != DateTimeUtil.CToD( "0", 2) ) )
                  {
                     AV13TotDev = (long)(AV13TotDev+1) ;
                  }
                  if ( ( A90LocDatC >= AV9DatInic ) && ( A90LocDatC <= AV10DatFin ) && ( A90LocDatC != DateTimeUtil.CToD( "0", 2) ) )
                  {
                     AV14TotCan = (long)(AV14TotCan+1) ;
                  }
                  pr_default.readNext(3);
               }
               pr_default.close(3);
               subGxsf6.loadCommand();
               pr_default.readNext(2);
            }
            pr_default.close(2);
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(0);
      }

      protected void closeCursors06( )
      {
         pr_default.close(1);
         pr_default.close(3);
         pr_default.close(2);
         pr_default.close(0);
      }

      public override void screen( )
      {
         GXPanel1 = new GXPanel(this, 3 , 25 , 1027 , 806 );
         this.setIBackground(UIFactory.getColor(15));
         this.setIForeground(UIFactory.getColor(6));
         GXPanel1 .setPixelsPerInch( 96 , 96 );
         GXPanel1.refreshFrame();
         edtavDatinicial = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),104, 65, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 104 , 65 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV9DatInic" );
         ((GXEdit) edtavDatinicial.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatinicial.addFocusListener(this);
         edtavDatinicial.getGXComponent().setHelpId("HLP_WMovDoCliente.htm");
         edtavDatfinal = new GUIObjectDatetime ( new GXEdit(8, "99/99/9999", UIFactory.getFont( "Courier New", 0, 9),221, 65, 80, 21, GXPanel1, false, ILabelConstants.BORDER_3D, GXTypeConstants.DATE, false, true, UIFactory.getColor(5), false) , GXPanel1 , 221 , 65 , 80 , 21 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , true , "AV10DatFin" );
         ((GXEdit) edtavDatfinal.getGXComponent()).setAlignment(ILabelConstants.LEFT);
         edtavDatfinal.addFocusListener(this);
         edtavDatfinal.getGXComponent().setHelpId("HLP_WMovDoCliente.htm");
         addSubfile ( subGxsf6  = new GXSubfile ( new MovDoCliente_load06(this), new MovDoCliente_flow06(this), false , new GXColumnDefinition[] {
          new GXColumnDefinition( new GUIObjectShort ( new GXCheckBox(GXPanel1, "" , new java.lang.Short(1), new java.lang.Short(0)) , null ,  0 , 0 , 78 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV15Depend" ), "Dependente"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 78 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectInt ( new GXEdit(9, "ZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 104, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 103 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV16PesCod" ), "Código"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 103 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectString ( new GXEdit(50, "@!", UIFactory.getFont( "Courier New", 0, 9),0, 0, 423, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.VARCHAR, false, false, 0, false) , null ,  0 , 0 , 422 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV17PesNom" ), "Nome completo"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 422 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectLong ( new GXEdit(10, "ZZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 108, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 107 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV13TotDev" ), "Devoluções"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 107 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         , new GXColumnDefinition( new GUIObjectLong ( new GXEdit(10, "ZZZZZZZZZ9", UIFactory.getFont( "Courier New", 0, 9),0, 0, 102, 19, GXPanel1, false, ILabelConstants.BORDER_NONE, GXTypeConstants.NUMERIC, false, false, 0, false) , null ,  0 , 0 , 101 , 18 , UIFactory.getColor(5) , UIFactory.getColor(8) , UIFactory.getFont( "Courier New", 0, 9) , false , "AV14TotCan" ), "Cancelamentos"  , UIFactory.getColor(18) , UIFactory.getColor(15) , 101 , UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8) , false , true )
         }, 38 , 18 , GXPanel1 , 78 , 91 , 872 , 702 ,  18 ));
         subGxsf6.addActionListener(this);
         subGxsf6.addFocusListener(this);
         subGxsf6.setSortOnClick(true);
         lbllbl2 = UIFactory.getLabel(GXPanel1, "De", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 78 , 69 , 17 , 13 );
         lbllbl4 = UIFactory.getLabel(GXPanel1, "até", ILabelConstants.LEFT, Integer.MAX_VALUE, UIFactory.getColor(8), UIFactory.getFont( "MS Sans Serif", IFontConstants.BOLD, 8), false, ILabelConstants.BORDER_NONE , 195 , 69 , 19 , 13 );
         focusManager.setControlList(new IFocusableControl[] {
                   edtavDatinicial ,
                   edtavDatfinal ,
                   subGxsf6
         });
      }

      public override void setFocusFirst( )
      {
         setFocus(subGxsf6, true);
      }

      public override void reloadDynamicLists( int id )
      {
      }

      protected void variablesToSubfile06( )
      {
         subwmovdocliente06.setVDepende(AV15Depend);
         subwmovdocliente06.setVPesCodNaGrid(AV16PesCod);
         subwmovdocliente06.setVPesNomNaGrid(AV17PesNom);
         subwmovdocliente06.setVTotDevolucao(AV13TotDev);
         subwmovdocliente06.setVTotCancelamento(AV14TotCan);
      }

      protected void subfileToVariables06( )
      {
         AV15Depend = subwmovdocliente06.getVDepende();
         AV16PesCod = subwmovdocliente06.getVPesCodNaGrid();
         AV17PesNom = subwmovdocliente06.getVPesNomNaGrid();
         AV13TotDev = subwmovdocliente06.getVTotDevolucao();
         AV14TotCan = subwmovdocliente06.getVTotCancelamento();
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
         if ( subGxsf6.inValidElement() )
         {
            subwmovdocliente06 = ( subwmovdocliente06 ) subGxsf6.getCurrentElement() ;
         }
         else
         {
            subwmovdocliente06 = new subwmovdocliente06 ();
         }
         subfileToVariables06 ();
      }

      protected void eventLevelResetContext( )
      {
         variablesToSubfile06 ();
         subGxsf6.refreshLineValue(subwmovdocliente06);
      }

      protected void reloadGridRow( )
      {
         if ( subGxsf6.inValidElement() )
         {
            subwmovdocliente06 = ( subwmovdocliente06 ) subGxsf6.getCurrentElement() ;
         }
         else
         {
            subwmovdocliente06 = new subwmovdocliente06 ();
         }
         subfileToVariables06 ();
      }

      public override void actionEventDispatch( Object eventSource )
      {
         if ( subGxsf6.isEventSource(eventSource) ) {
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
         subwmovdocliente06 = new subwmovdocliente06();
         gxIsRefreshing = false ;
         returnInSub = false ;
         AV9DatInic = (DateTime)(DateTime.MinValue) ;
         Gx_date = (DateTime)(DateTime.MinValue) ;
         AV10DatFin = (DateTime)(DateTime.MinValue) ;
         AV16PesCod = 0 ;
         AV15Depend = 0 ;
         scmdbuf = "" ;
         W002L2_A13PesCodi = new int[1] ;
         W002L2_A14PesNome = new String[] {""} ;
         W002L2_n14PesNome = new bool[] {false} ;
         A13PesCodi = 0 ;
         A14PesNome = "" ;
         n14PesNome = false ;
         AV17PesNom = "" ;
         AV13TotDev = 0 ;
         AV14TotCan = 0 ;
         W002L3_A86LocCodi = new int[1] ;
         W002L3_A91LocCliP = new int[1] ;
         W002L3_n91LocCliP = new bool[] {false} ;
         W002L3_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         W002L3_n88LocDatL = new bool[] {false} ;
         W002L3_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         W002L3_n89LocDatD = new bool[] {false} ;
         W002L3_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         W002L3_n90LocDatC = new bool[] {false} ;
         A91LocCliP = 0 ;
         n91LocCliP = false ;
         A88LocDatL = (DateTime)(DateTime.MinValue) ;
         n88LocDatL = false ;
         A89LocDatD = (DateTime)(DateTime.MinValue) ;
         n89LocDatD = false ;
         A90LocDatC = (DateTime)(DateTime.MinValue) ;
         n90LocDatC = false ;
         W002L4_A13PesCodi = new int[1] ;
         W002L4_A46PesDepC = new int[1] ;
         W002L4_A47PesDepN = new String[] {""} ;
         W002L4_n47PesDepN = new bool[] {false} ;
         A46PesDepC = 0 ;
         A47PesDepN = "" ;
         n47PesDepN = false ;
         W002L5_A86LocCodi = new int[1] ;
         W002L5_A91LocCliP = new int[1] ;
         W002L5_n91LocCliP = new bool[] {false} ;
         W002L5_A88LocDatL = new DateTime[] {DateTime.MinValue} ;
         W002L5_n88LocDatL = new bool[] {false} ;
         W002L5_A89LocDatD = new DateTime[] {DateTime.MinValue} ;
         W002L5_n89LocDatD = new bool[] {false} ;
         W002L5_A90LocDatC = new DateTime[] {DateTime.MinValue} ;
         W002L5_n90LocDatC = new bool[] {false} ;
         Gx_date = DateTimeUtil.Today( ) ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wmovdocliente__default(),
            new Object[][] {
                new Object[] {
               W002L2_A13PesCodi, W002L2_A14PesNome, W002L2_n14PesNome
               }
               , new Object[] {
               W002L3_A86LocCodi, W002L3_A91LocCliP, W002L3_n91LocCliP, W002L3_A88LocDatL, W002L3_n88LocDatL, W002L3_A89LocDatD, W002L3_n89LocDatD, W002L3_A90LocDatC, W002L3_n90LocDatC
               }
               , new Object[] {
               W002L4_A13PesCodi, W002L4_A46PesDepC, W002L4_A47PesDepN, W002L4_n47PesDepN
               }
               , new Object[] {
               W002L5_A86LocCodi, W002L5_A91LocCliP, W002L5_n91LocCliP, W002L5_A88LocDatL, W002L5_n88LocDatL, W002L5_A89LocDatD, W002L5_n89LocDatD, W002L5_A90LocDatC, W002L5_n90LocDatC
               }
            }
         );
         reloadDynamicLists(0);
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      protected short AV15Depend ;
      protected int AV11PesCod ;
      protected int AV16PesCod ;
      protected int A13PesCodi ;
      protected int A91LocCliP ;
      protected int A46PesDepC ;
      protected long AV13TotDev ;
      protected long AV14TotCan ;
      protected String scmdbuf ;
      protected DateTime AV9DatInic ;
      protected DateTime Gx_date ;
      protected DateTime AV10DatFin ;
      protected DateTime A88LocDatL ;
      protected DateTime A89LocDatD ;
      protected DateTime A90LocDatC ;
      protected bool gxIsRefreshing ;
      protected bool returnInSub ;
      protected bool n14PesNome ;
      protected bool n91LocCliP ;
      protected bool n88LocDatL ;
      protected bool n89LocDatD ;
      protected bool n90LocDatC ;
      protected bool n47PesDepN ;
      protected String A14PesNome ;
      protected String AV17PesNom ;
      protected String A47PesDepN ;
      protected IGxDataStore dsDefault ;
      protected IGxContext context ;
      protected bool IsMain ;
      protected subwmovdocliente06 subwmovdocliente06 ;
      protected IDataReader W002L2 ;
      protected IDataStoreProvider pr_default ;
      protected int[] W002L2_A13PesCodi ;
      protected String[] W002L2_A14PesNome ;
      protected bool[] W002L2_n14PesNome ;
      protected IDataReader W002L3 ;
      protected int[] W002L3_A86LocCodi ;
      protected int[] W002L3_A91LocCliP ;
      protected bool[] W002L3_n91LocCliP ;
      protected DateTime[] W002L3_A88LocDatL ;
      protected bool[] W002L3_n88LocDatL ;
      protected DateTime[] W002L3_A89LocDatD ;
      protected bool[] W002L3_n89LocDatD ;
      protected DateTime[] W002L3_A90LocDatC ;
      protected bool[] W002L3_n90LocDatC ;
      protected IDataReader W002L4 ;
      protected int[] W002L4_A13PesCodi ;
      protected int[] W002L4_A46PesDepC ;
      protected String[] W002L4_A47PesDepN ;
      protected bool[] W002L4_n47PesDepN ;
      protected IDataReader W002L5 ;
      protected int[] W002L5_A86LocCodi ;
      protected int[] W002L5_A91LocCliP ;
      protected bool[] W002L5_n91LocCliP ;
      protected DateTime[] W002L5_A88LocDatL ;
      protected bool[] W002L5_n88LocDatL ;
      protected DateTime[] W002L5_A89LocDatD ;
      protected bool[] W002L5_n89LocDatD ;
      protected DateTime[] W002L5_A90LocDatC ;
      protected bool[] W002L5_n90LocDatC ;
      protected GXPanel GXPanel1 ;
      protected GUIObjectDatetime edtavDatinicial ;
      protected GUIObjectDatetime edtavDatfinal ;
      protected GXSubfile subGxsf6 ;
      protected ILabel lbllbl2 ;
      protected ILabel lbllbl4 ;
   }

   public class wmovdocliente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new GeneXus.Data.NTier.ADO.Cursor[] {
          new GeneXus.Data.NTier.ADO.ForEachCursor(def[0])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[1])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[2])
         ,new GeneXus.Data.NTier.ADO.ForEachCursor(def[3])
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
          Object[] prmW002L3 ;
          prmW002L3 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmW002L4 ;
          prmW002L4 = new Object[] {
          new Object[] {"@PesCodigo",SqlDbType.Int,9,0}
          } ;
          Object[] prmW002L5 ;
          prmW002L5 = new Object[] {
          new Object[] {"@PesDepCodigo",SqlDbType.Int,9,0}
          } ;
          def= new GeneXus.Data.NTier.ADO.CursorDef[] {
              new GeneXus.Data.NTier.ADO.CursorDef("W002L2", "SELECT [PesCodigo], [PesNome] FROM [PESSOA] WITH (NOLOCK) WHERE [PesCodigo] = @AV16PesCod ORDER BY [PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002L2,1,0,true,true )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W002L3", "SELECT [LocCodigo], [LocCliPesCodigo], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCliPesCodigo] = @PesCodigo ORDER BY [LocCliPesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002L3,31,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W002L4", "SELECT T1.[PesCodigo], T1.[PesDepCodigo] AS PesDepCodigo, T2.[PesNome] AS PesDepNome FROM ([CLIENTEDEPENDENTE] T1 WITH (NOLOCK) INNER JOIN [PESSOA] T2 WITH (NOLOCK) ON T2.[PesCodigo] = T1.[PesDepCodigo]) WHERE T1.[PesCodigo] = @PesCodigo ORDER BY T1.[PesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002L4,31,0,true,false )
             ,new GeneXus.Data.NTier.ADO.CursorDef("W002L5", "SELECT [LocCodigo], [LocCliPesCodigo], [LocDatLocacao], [LocDatDevolucao], [LocDatCancelamento] FROM [LOCACAO] WITH (NOLOCK) WHERE [LocCliPesCodigo] = @PesDepCodigo ORDER BY [LocCliPesCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmW002L5,31,0,true,false )
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
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                break;
             case 2 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(3);
                break;
             case 3 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
             case 1 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 2 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                break;
       }
    }

 }

}
