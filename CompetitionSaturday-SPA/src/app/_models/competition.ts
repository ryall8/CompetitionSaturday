import { Competitor } from './Competitor';

export interface Competition {
    id: number;
    name: string;
    streetAddress: string;
    city: string;
    stateCode: string;
    zip: string;
    eventDate: Date;
    createdDate: Date;
    lastActive: Date;
    competitors?: Competitor[];
}
