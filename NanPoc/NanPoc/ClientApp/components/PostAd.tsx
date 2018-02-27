import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class PostAds extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <h1>Post a new ad</h1> 

            <form className="commentForm" onSubmit={() => { this.PostData() }}>
                <input type="text" placeholder="Your name" />
                <input type="text" placeholder="Say something..." />
                <input type="submit" value="Post" />
            </form>            
        </div>;
    }  

    PostData() {
        alert("posting");

    }
}
