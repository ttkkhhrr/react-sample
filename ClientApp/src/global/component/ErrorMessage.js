//Validation用
//import * as yup from 'yup';
import React from 'react';
//material-ui用
import { makeStyles } from '@material-ui/core/styles'
import { Box } from '@material-ui/core'


const useStyles = makeStyles(theme => ({
    root: {
        color: theme.palette.error.main,
        fontSize: theme.typography.caption.fontSize

    }
}))
//エラー表示用コンポーネント
export const ErrorMessage = ({errors, name}) => {
    const classes = useStyles()

    if(!errors || !errors[name]){
        return (
            <></>
        )
    }

    return (
        <Box className={classes.root}>
            <label>{errors[name]?.message}</label>
        </Box>
        
    )
}