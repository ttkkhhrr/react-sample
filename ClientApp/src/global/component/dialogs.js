import React, {useState, useEffect} from 'react';
import {useDispatch, useSelector } from 'react-redux'

import {yesNoDialogActions} from '../stores/yesNoDialogSlice'
import {messageDialogActions} from '../stores/messageDialogSlice'
import {errorDialogActions} from '../stores/errorDialogSlice'

import Button from '@material-ui/core/Button';
import Dialog from '@material-ui/core/Dialog';
import DialogActions from '@material-ui/core/DialogActions';
import DialogContent from '@material-ui/core/DialogContent';
import DialogContentText from '@material-ui/core/DialogContentText';
import DialogTitle from '@material-ui/core/DialogTitle';

import { makeStyles } from '@material-ui/core/styles';

const useStyles = makeStyles(theme => ({
    messageTitle: {
            //color: "#fff",
            //backgroundColor: "#3f51b5"
    }
}))


//Yes・Noを表示するダイアログ
export const YesNoDialog = () => {
    const classes = useStyles()
    const dispatch = useDispatch()

    const {open, title, message, eventWhenOK, eventWhenNo} = useSelector(state => state.yesNoDialog)

    useEffect(() => {
        console.log("MyDialogのuseEffect")
    })

    const handleOK = async () => {
        eventWhenOK && await eventWhenOK();
        handleClose();
    }

    const handleClose = async () => {
        eventWhenNo && await eventWhenNo();
        dispatch(yesNoDialogActions.isOpen(false))
    }

    const dispTitle = title == "" ? "" : title

    return (
        <Dialog
            open={open}
            onClose={handleClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" className={classes.messageTitle}>{dispTitle}</DialogTitle>
            <DialogContent>
                <DialogContentText id="alert-dialog-description">
                    {message}
                </DialogContentText>
            </DialogContent>
            <DialogActions>
                <Button onClick={handleClose} color="primary">
                    いいえ
                </Button>
                <Button onClick={handleOK} color="primary">
                    はい
                </Button>
            </DialogActions>
        </Dialog>
    )
}


//メッセージを表示するダイアログ
export const MessageDialog = () => {
    const classes = useStyles()
    const dispatch = useDispatch()

    const {open, title, message, eventWhenOK} = useSelector(state => state.messageDialog)

    useEffect(() => {
        console.log("MessageDialogのuseEffect")
    })

    const handleOK = async () => {
        handleClose();
        eventWhenOK && await eventWhenOK();
    }

    const handleClose = () => {
        dispatch(messageDialogActions.isOpen(false))
    }
    
    const dispTitle = title == "" ? "メッセージ" : title

    return (
        <Dialog
            open={open}
            onClose={handleClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" className={classes.messageTitle}>{dispTitle}</DialogTitle>
            <DialogContent>
                <DialogContentText id="alert-dialog-description">
                    {message}
                </DialogContentText>
            </DialogContent>
            <DialogActions>
                <Button onClick={handleOK} color="primary">
                    OK
                </Button>
            </DialogActions>
        </Dialog>
    )
}


//エラーメッセージを表示するダイアログ
export const ErrorDialog = () => {
    const classes = useStyles()
    const dispatch = useDispatch()

    const {open, title, message, eventWhenOK} = useSelector(state => state.errorDialog)

    useEffect(() => {
        console.log("ErrorDialogのuseEffect")
    })

    const handleOK = async () => {
        eventWhenOK && await eventWhenOK();
        handleClose();
    }

    const handleClose = () => {
        dispatch(errorDialogActions.isOpen(false))
    }

    const dispTitle = title == "" ? "メッセージ" : title

    return (
        <Dialog
            open={open}
            onClose={handleClose}
            aria-labelledby="alert-dialog-title"
            aria-describedby="alert-dialog-description"
        >
            <DialogTitle id="alert-dialog-title" className={classes.messageTitle}>{dispTitle}</DialogTitle>
            <DialogContent>
                <DialogContentText id="alert-dialog-description">
                    {message}
                </DialogContentText>
            </DialogContent>
            <DialogActions>
                <Button onClick={handleOK} color="primary">
                    OK
                </Button>
            </DialogActions>
        </Dialog>
    )
}
